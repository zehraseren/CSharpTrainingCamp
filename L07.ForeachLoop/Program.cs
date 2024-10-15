using System;

namespace L07.ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH LOOP | FOREACH DÖNGÜSÜ

            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //*******************************************************************

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //*******************************************************************

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //*******************************************************************

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int number in numbers)
            //{
            //    total += number;
            //}

            //Console.WriteLine(total);

            //*******************************************************************

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //*******************************************************************

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region GRADING SYSTEM IMPLEMENTATION | NOTLANDIRMA SİSTEMİ UYGULAMASI

            //Console.Write("******* C# EĞİTİM KAMPI SINAV UYGULAMASI *******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //// Sınıftaki öğrenci sayısını kullanıcıdan alma
            //Console.WriteLine("----------------------------------------------");
            //Console.Write("Sınıfta bulunan öğrenci sayısı: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------------------");

            //// Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totamExamResult = 0;

            //    // Her öğrenci için 3 sınav notu girişi
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totamExamResult += value; // Notlar burada toplanır
            //    }

            //    Console.WriteLine();
            //    studentExamAvg[i] = totamExamResult / 3;
            //}

            //// Sınav Ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

            //    // Öğrencilerin ortalaması, geçme ve kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}