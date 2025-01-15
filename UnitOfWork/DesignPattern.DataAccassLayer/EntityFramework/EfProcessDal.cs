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
    public class EfProcessDal : GenericRepositories<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {

        }
    }
}
