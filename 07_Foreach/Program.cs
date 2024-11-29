using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach

            //Foreach(1;2;3;4)

            //1:Değişken Türü
            //2:Değişken Adı
            //3:in
            //4:Listeler,Koleksiyonlar,Dizi

            //string[] cities = {"Milano","Roma","Budapeşte","Ankara","İstanbul","Varşova"};

            //foreach (string x in cities) 
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = {45,78,985,635,74,11,22,33,41,205,6578,10394 };
            //foreach (int number in numbers) 
            //{
            //    Console.WriteLine(number);  
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers) 
            //{
            //    if (number % 2 == 0) 
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


            //string word = "Merhaba";
            //foreach(char c in word) 
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("***** C# Eğitim Kampı Sınav Sistemi Uygulaması");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-----------------------------");
            //Console.Write("Sınısınızdaki Kaç Öğrenci Var: ");
            //int studentcount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------");

            ////Öğrenci İsimlerini ve Sınav ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentcount];
            //double[] studentExamAve = new double[studentcount];

            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.Write($"{i + 1}.Öğrencinin İsmini Giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} İsimli Öğrencinin {j + 1}. Notunu Giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine();

            //    studentExamAve[i] = totalExamResult / 3;
            //}

            ////Sınav Ortalamaları

            //for (int i = 0; i < studentcount; i++)
            //{
            //    Console.WriteLine("----------------------------");
            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin sınav notu ortalaması : {studentExamAve[i]}");
            //    //Öğrencinin Ortalaması Ve Kalıp Geçme Durumu
            //    if (studentExamAve[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci derste başarılı olmuştur.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci derste başarısız olmuştur.");
            //    }
            //    Console.WriteLine("----------------------------");

            //}


            #endregion

            Console.Read();
        }
    }
}
