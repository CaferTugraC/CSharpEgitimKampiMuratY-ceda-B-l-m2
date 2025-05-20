using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtim_301_OOP.EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CatagoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CatagoryStatus { get; set; }
        public List<Product> Products { get; set; } 

    }
}


//int x; // x bir filed türüdür
//public int y { get; set; } // y bir property türüdür

//void Metod()
//{
//    int a; // a bir variable türüdür
//}