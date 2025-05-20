using CSharpEgtim_301_OOP.DataAccsessLayer.Abstarct;
using CSharpEgtim_301_OOP.DataAccsessLayer.Repositories;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtim_301_OOP.DataAccsessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {

    }
}
