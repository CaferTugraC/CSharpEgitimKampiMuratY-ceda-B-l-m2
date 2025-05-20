using CSharpEgtim_301_OOP.DataAccsessLayer.Abstarct;
using CSharpEgtim_301_OOP.DataAccsessLayer.Repositories;
using CSharpEgtim_301_OOP.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Context = CSharpEgtim_301_OOP.DataAccsessLayer.Context.Context;

namespace CSharpEgtim_301_OOP.EntityLayer.Concrete
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
      

        public List<Object> GetProductsWithCategory()
        {
            var context = new Context();
            var values = context.Products
                .Select(x => new
                {
                    ProductId = x.ProductId,
                    ProductName = x.ProductName,
                    ProductDescription = x.ProductDescription,
                    ProductPrice = x.ProductPrice,
                    ProductStock = x.ProductStock,
                    CategoryId = x.CategoryId,
                    CategoryName = x.Category.CategoryName
                }).ToList();

            return values.Cast<object>().ToList();
        }
    }
}
