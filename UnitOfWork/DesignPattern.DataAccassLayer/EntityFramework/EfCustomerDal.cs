using DesignPattern.DataAccassLayer.Abstract;
using DesignPattern.DataAccassLayer.Concrate;
using DesignPattern.DataAccassLayer.Repositories;
using DesignPattern.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccassLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepositories<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context): base(context)
        {

        }
    }
}
