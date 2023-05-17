using EasyCashIdentityProject.BusinessLayer.Abstracts;
using EasyCashIdentityProject.DataAccessLayer.Abstacts;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDAL _cutomerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDAL cutomerAccountProcessDal)
        {
            _cutomerAccountProcessDal = cutomerAccountProcessDal;
        }

        public void TDelete(CustomerAccountProcess entity)
        {
            _cutomerAccountProcessDal.Delete(entity);
        }

        public List<CustomerAccountProcess> TGetAll()
        {
            return _cutomerAccountProcessDal.GetAll();
        }

        public CustomerAccountProcess TGetById(int id)
        {
            return _cutomerAccountProcessDal.GetById(id);
        }

        public void TInsert(CustomerAccountProcess entity)
        {
            _cutomerAccountProcessDal.Insert(entity);
        }

        public void TUpdate(CustomerAccountProcess entity)
        {
            _cutomerAccountProcessDal.Update(entity);
        }
    }
}
