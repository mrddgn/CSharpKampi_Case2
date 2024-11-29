using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methodlar

            //();
            //Geriye Değer Döndürmeyen Methodlardır
            //Customer-Listele,Ekle,Sil,Günceller
            //Void

            //void customerList() 
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //customerList();
            //customerList();
            //customerList();
            //customerList();

            //void sum() 
            //{
            //    int x = 4;
            //    int y=8;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Methodlar

            //void writeMethod(string customerName) 
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Kerim Kaan Doğan");

            //void customerCard(string name,string surname) 
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surname);
            //}
            //customerCard("Kerim Kaan","Doğan");
            //customerCard("Mislina","İldeniz");


            #endregion

            #region Geriye Değer Döndürmeyen İnt Parametreli Methodlar

            //void Sum(int number1,int number2,int number3) 
            //{
            //    int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}
            //Sum(88,52,60);

            #endregion

            #region Geriye Değer Döndüren Methodlar

            //string CustomerName() 
            //{
            //    return " Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Methodlar

            //string CountryCard(string countryName, string capital,string flagColor) 
            //{
            //    string cardInfo = "Ülke: " + countryName + " -Başkent: " + capital + " -Bayrak Rengi: " + flagColor;
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("Lütfen Ülke İsmi Giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Lütfen Başkent İsmi Giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Lütfen Bayrak Rengini  Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı+Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int Parametreli Methodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçti" + " Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " İsimli Öğrenci Sınavı Geçemedi" + " Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ahmet", 45, 50, 50));
            //Console.WriteLine(ExamResult("Ali", 45, 25, 30));
            //Console.WriteLine(ExamResult("Mehmet", 80, 95, 100));

            #endregion

            Console.Read();
        }
    }
}
