using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            // Değişken Türü [] Dizinin Adı= new Değişken Türü [Eleman Sayısı]

            //string [] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[1]);

            //string[] cities = new string[5];

            //cities[0]= "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];

            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 8;
            //numbers[3] = 246;
            //numbers[7] = 200;

            //Console.WriteLine(numbers[8]);

            //string[] cities = { "Prag","Roma","Atina","İstanbul","Bursa" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizinin Tüm Elemanlarını Listeleme

            //string[] colors = {"Sarı","Kırmızı","Beyaz","Mavi","Yeşil","Turuncu","Pembe"};

            //for(int i=0;i<colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 2, 8, 22, 21, 156, 2844, 520, 260, 155, 1148, 75, 191, 687 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b','2','x','/','*' };
            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myarray = {47,85,95,41,25,635,789,86,100};
            //int maxnumber = myarray[0];

            //for (int i = 0; i <myarray.Length; i++) 
            //{
            //    if (myarray[i]>maxnumber) 
            //    {
            //        maxnumber = myarray[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);   

            //string[] people = {"Ali","Ahmet","Ayşe","Buse","Cem","Deniz" };
            //Console.WriteLine(people.Length);

            //int[] numbers = { 45, 88, 20, 24, 18, 662, 120, 665, 1080, 28 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 88, 20, 24, 18, 662, 120, 665, 1080, 28 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metodlar

            //string[] customers = {"Ali","Buse","Ayşegül","Merve","Çınar","Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 25, 50, 10, 88, 32, 988, 1050, 3200, 24, 8 };
            //Console.WriteLine("Dizinin En Büyük Değeri: " + numbers.Max() + " " +
            //    "Dizinin En Küçük Değeri: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //for (int i = 0;i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 50, 21, 24, 28, 150 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum); 

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
