﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğrudur.");

            //}
            //else 
            //{
            //    Console.WriteLine("Şifre Yanlıştır.");
            //}


            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Bilgi Doğrudur.");
            //}
            //else 
            //{
            //    Console.WriteLine("Bilgi Yanlıştır.");
            //}


            //int number;
            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number==5) 
            //{
            //    Console.WriteLine("Girilen Sayı Doğrudur.");
            //}
            //else 
            //{
            //    Console.WriteLine("Girilen Sayı Hatalıdır."); 
            //}


            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat.";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta.";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi.";
            //}
            //if (average > 84)
            //{
            //    result = "Çok İyi.";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Bir Şehir Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "ankara" | city == "new york" | city == "boston" | city == "dubai" | city == "qatar")
            //{
            //    Console.WriteLine("Şehir Mevcuttur.");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değildir.");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Adı Hatalıdır !");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz.");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number =26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.WriteLine("1.Sayının 2.Sayıya Bölümünden Kalan: "+result);


            //Console.Write("Lütfen Bir Sayı Griniz: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir.");
            //}

            #endregion

            #region Char Değişkenler ve Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team=Convert.ToChar(Console.ReadLine());

            //if (team == 'G' | team == 'g') 
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'F' | team == 'f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Döner Üstü Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Kebabı");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorba");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ice Tea");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Ayran");
            //    Console.WriteLine("5-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Fıstıklı & Ormanmeyveli Muhallebi");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //}


            #endregion

            #region SwitchCase

            //Console.Write("Lütfen bir Ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Vei Girişi !"); break;
            //}

            #endregion

            #region SwitchCase Hesap Makinesi

            //int number1, number2, result;
            //char symbol;
            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

                
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

                
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
                
               
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}


            #endregion

            Console.Read();

        }
    }
}
