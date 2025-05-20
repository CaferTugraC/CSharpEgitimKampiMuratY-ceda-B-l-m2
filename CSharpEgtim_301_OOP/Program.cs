using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgtim_301_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //int topla(int a, int b)
            //{
            //    return a + b;
            //}

            //Console.WriteLine(topla(5, 10));

            #endregion

            #region SQL

            //SqlConnection connection = new SqlConnection("Data Source=CAFER\\SQLEXPRESS;Initial Catalog=CSharp_EgtimDB;Integrated Security=True;Pooling=False");

            //connection.Open();

            //SqlCommand listCatalog = new SqlCommand("SELECT * FROM TblCategory", connection);


            //SqlDataAdapter adapter = new SqlDataAdapter(listCatalog);
            //DataTable Catalog = new DataTable();
            //adapter.Fill(Catalog);

            #endregion

            #region DataBase Crud
            // Crud--> CREATE - READ - UPDATE - DELETE

            //string categoryName = Console.ReadLine();

            //SqlCommand insertCatagoryName = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@p1)", connection);
            //insertCatagoryName.Parameters.AddWithValue("@p1", categoryName);
            //insertCatagoryName.ExecuteNonQuery();
            //Console.WriteLine("Kayıt Eklendi");

            //connection.Close();

            // ÜRÜN EKLEME
            //Console.Write("Ürün Adı Giriniz: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı Giriniz: ");
            //double productPrice = double.Parse(Console.ReadLine());
            //bool productStatus = true; // default

            //SqlCommand insertProduct = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES (@productName, @productPrice, @productStatus)", connection);
            //insertProduct.Parameters.AddWithValue("@productName", productName);
            //insertProduct.Parameters.AddWithValue("@productPrice", productPrice);
            //insertProduct.Parameters.AddWithValue("@productStatus", productStatus);
            //insertProduct.ExecuteNonQuery();
            //Console.WriteLine("Kayıt Eklendi");

            // ÜRÜN LİSTELEME
            //SqlCommand listProduct = new SqlCommand("SELECT * FROM TblProduct", connection);

            //SqlDataAdapter adapterProduct = new SqlDataAdapter(listProduct);
            //DataTable product = new DataTable();
            //adapterProduct.Fill(product);

            //foreach (DataRow item in product.Rows)
            //{
            //    Console.WriteLine(item["ProductID"] + " "  + item["ProductName"] + " " + item["ProductPrice"]);
            //}

            //ÜRÜN SİLME
            //Console.Write("Silmek istediğiniz ürünün ID'sini giriniz: ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlCommand deleteProduct = new SqlCommand("DELETE FROM TblProduct WHERE ProductID=@productID", connection);
            //deleteProduct.Parameters.AddWithValue("@productID", productID);
            //deleteProduct.ExecuteNonQuery();
            //Console.WriteLine("Kayıt Silindi");


            //ÜRÜN GÜNCELLEME
            //int updateProductID = 0;
            //string updateProductName = "";
            //double updateProductPrice = 0;
            //bool updateProductStatus = true;    // default
            //while (true)
            //{
            //    SqlCommand updateProduct = new SqlCommand("UPDATE TblProduct SET ProductName=@updateProductName,ProductPrice=@updateProductPrice,ProductStatus=@updateProductStatus WHERE ProductID=@productID", connection);
            //    // PARAMETLERİ KULLANICIDAN AL
            //    Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz (Çıkmak için -1 yazın): ");
            //    updateProductID = int.Parse(Console.ReadLine());
            //    if (updateProductID == -1)
            //    {
            //        break;
            //    }
            //    Console.Write("Yeni Ürün Adı Giriniz: ");
            //    updateProductName = Console.ReadLine();
            //    Console.Write("Yeni Ürün Fiyatı Giriniz: ");
            //    updateProductPrice = double.Parse(Console.ReadLine());
            //    //Console.Write("Yeni Ürün Durumu Giriniz (True/False): ");
            //    //updateProductStatus = bool.Parse(Console.ReadLine());
            //    // PARAMETRELERİ GÜNCELLE
            //    updateProduct.Parameters.AddWithValue("@productID", updateProductID);
            //    updateProduct.Parameters.AddWithValue("@updateProductName", updateProductName);
            //    updateProduct.Parameters.AddWithValue("@updateProductPrice", updateProductPrice);
            //    updateProduct.Parameters.AddWithValue("@updateProductStatus", updateProductStatus);
            //    // GÜNCELLEME İŞLEMİ
            //    updateProduct.ExecuteNonQuery();
            //    Console.WriteLine("Kayıt Güncellendi");
            //}
            // connection.Close();

            #endregion

            Console.Read();
        }
    }
}
