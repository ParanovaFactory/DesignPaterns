using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrate;
using DesignPattern.DataAccessLayer.Repositories;
using DesignPattern.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepositories<Category>, ICategoryDal
    {
        public EfCategoryDal(Context context) : base(context)
        {
        }
    }
}
