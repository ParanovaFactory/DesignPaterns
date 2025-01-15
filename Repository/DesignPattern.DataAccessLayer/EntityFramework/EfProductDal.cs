using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrate;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepositories<Product>, IProductDal
    {
        private readonly Context _context;

        public EfProductDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWihtCategory()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }
    }
}
