using System;

namespace L05.LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 STARS IN A ROW | ALT ALTA 10 TANE YILDIZ

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region 10 STARS SIDE BY SIDE | YAN YANA 10 TANE YILDIZ

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region 10 STARS IN A ROW, 10 STARS IN EACH ROW | ALT ALTA 10 TANE YILDZ, HER SATIRDA 10 TANE YILDIZ

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion
            #region RIGHT TRIANGLE | DİK ÜÇGEN

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region INVERTED RIGHT TRIANGLE | TERS DİK ÜÇGEN

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region RIGHT AND INVERTED RIGHT TRIANGLE | DİK VE TERS DİK ÜÇGEN

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 5; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region DIAMOND LINE | BAKLAVA DİLİMİ

            //int n = 5;

            //// TOP PART
            //for (int i = 1; i <= n; i++)
            //{
            //    // GAPS
            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // STARS
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// BOTTOM PART
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // GAPS
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // STARS
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region PYRAMID | PİRAMİT

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    // GAPS
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // STARS
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region INVERTED PYRAMID

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    // GAPS
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // STARS
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();
        }
    }
}