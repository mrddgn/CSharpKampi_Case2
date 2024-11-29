using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////CRUD-->Create-Read-Update-Delete
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection=new SqlConnection("Data Source=MSI\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCatgory(CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori Başarıyla Eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=MSI\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün Ekleme Başarılı!");

            #endregion


            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach(DataRow row in dataTable.Rows) 
            //{
            //    foreach (var item in row.ItemArray) 
            //    {
            //        Console.Write(item.ToString()+ " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close(); 

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ProductId: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=MSI\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.         Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün productId: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün productName: ");
            //string productName= Console.ReadLine();
            //Console.Write("Güncellenecek Ürün productPrice: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source=MSI\\SQLEXPRESS;initial catalog=EğitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Günceleme Başarılı! ");

            #endregion

            Console.Read();

        }
    }
}
