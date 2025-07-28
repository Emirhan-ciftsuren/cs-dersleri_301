using c_dersleri_301.DataAccessLayer.Abstract;
using c_dersleri_301.DataAccessLayer.Repositories;
using c_dersleri_301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dersleri_301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal:GenericRepository<Admin>, IAdmindal
    {
    }
}
