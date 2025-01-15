using DesignPattern.BussinessLayer.Abstract;
using DesignPattern.DataAccassLayer.Abstract;
using DesignPattern.DataAccassLayer.UnitOfWork;
using DesignPattern.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BussinessLayer.Concrate
{
    public class ProcessManager : IProcessService
    {
        private readonly IProcessDal _processDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public ProcessManager(IProcessDal processDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _processDal = processDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Process t)
        {
            _processDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public Process TGetById(int id)
        {
            return _processDal.GetById(id);
        }

        public List<Process> TGetList()
        {
            return _processDal.GetList();
        }

        public void TInsert(Process t)
        {
            _processDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Process> t)
        {
            _processDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Process t)
        {
            _processDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
