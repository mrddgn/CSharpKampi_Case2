using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı: "+applePrice+" TL");
            //Console.WriteLine("----Portakal Birim Fiyatı: "+orangePrice+ " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı: "+strawberryPrice+ " TL");
            //Console.WriteLine("----Patates Birim Fiyatı: "+potatoPrice+ " TL");
            //Console.WriteLine("----Domates Birim Fiyatı: "+tomatoPrice+ "  TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice= orangePrice * orangeGram;
            //double strawberryTotalPrice= strawberryPrice * strawberryGram;
            //double potatoTotalPrice= potatoPrice * potatoGram;
            //double tomatoTotalPrice= tomatoPrice * tomatoGram;

            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("----Elma-"+"Birim Fiyatı: "+applePrice+"-Gramaj: "+appleGram+"-Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("----Portakal-"+"Birim Fiyatı: "+orangePrice+"-Gramaj: "+orangeGram+"-Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("----Çilek-"+"Birim Fiyatı: "+strawberryPrice+"-Gramaj: "+strawberryGram+"-Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("----Patetes-"+"Birim Fiyatı: "+potatoPrice+"-Gramaj: "+potatoGram+"-Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("----Domates-"+"Birim Fiyatı: "+tomatoPrice+"-Gramaj: "+tomatoGram+"-Toplam Tutar: "+tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı: "+shoppingTotalPrice+" TL");


            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'M';
            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler
            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi*****");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcu Kimlik No:");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Yolcu Kimlik No: " + passangerIdentityNumber + " " + "-Yolcu Adı Soyadı: " + passangerName + " " + passangerSurname + " " +
            //    passangerDistrict + "/" + passangerCity + " " + passangerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //int shoescount, computercount, chaircount, tvcount;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //Console.Write("Lütfen Aldığınız Ayakkabi Sayısını Giriniz: ");
            //shoescount=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computercount=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chaircount=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvcount=int.Parse(Console.ReadLine());

            //int totalPrice=shoescount*shoesPrice + computercount*computerPrice + chaircount*chairPrice + tvcount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Ödenecek Toplam Tutar: "+totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;


            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);

            #endregion

            #region Klavyeden Karakter Girişi

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);



            #endregion


            Console.Read();


        }
    }
}
