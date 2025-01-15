using DesignPattern.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BussinessLayer.Abstract
{
    public interface ICustomerService : IGenericService<Customer>
    {
    }
}
