using System;

namespace L04.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR LOOP | FOR DÖNGÜSÜ

            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütten ekrana yazılmasını istediğiniz adedi ekrana giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region MAKING DECISION WITH FOR LOOP | FOR DÜNGÜSÜ İLE KARAR YAPILARI

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region EXAMPLE WITH FOR LOOP | FOR DÖNGÜSÜ ÖRNEĞİ

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda oluşan bakteri sayısı: " + bacterium);
            //}

            #endregion

            #region WHILE LOOP | WHILE DÖNGÜSÜ

            // Şart sağlandığı sürece anlamı taşımaktadır.

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region MAKING DECISION WITH WHILE LOOP | WHILE DÖNGÜSÜ İLE KARAR YAPILARI

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            #endregion

            #region EXAMPLE WITH WHILE LOOP | WHILE DÖNGÜSÜ ÖRNEĞİ

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //Sayı 456 olsun.

            //Console.Write("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds, sum;
            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;
            //sum = hundreds + tens + ones;
            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            //Console.WriteLine(sum);

            #endregion

            Console.Read();
        }
    }
}