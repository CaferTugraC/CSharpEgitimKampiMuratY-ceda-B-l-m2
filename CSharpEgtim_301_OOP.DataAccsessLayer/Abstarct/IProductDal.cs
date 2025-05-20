using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;

namespace CSharpEgtim_301_OOP.DataAccsessLayer.Abstarct
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Object> GetProductsWithCategory();
    }
}
