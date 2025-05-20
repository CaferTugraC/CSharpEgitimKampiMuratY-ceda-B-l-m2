using CSharpEgtim_301_OOP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtim_301_OOP.BuisnessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Object> TGetProductWithCategory();
    }
}
