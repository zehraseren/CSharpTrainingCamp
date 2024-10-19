using System;

namespace L08.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region METHODS | METOTLAR

            /*
             * İkiye ayrılır:
             * 1. Geriye Değer Döndürmeyen Metotlar | Void Metotlar olarak da bilinir.
             * 2. Geriye Değer Döndüren Metotlar 
             */

            #endregion

            #region VOID METHODS | GERİYE DEĞER DÖNDÜRMEYEN METOTLAR

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();

            //*******************************************************************

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region VOID METHODS WITH STRING PARAMETERS | GERİYE DEĞER DÖNDÜRMEYEN STRING PARAMETRELİ METOTLAR

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            //*******************************************************************

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region VOID METHODS WITH INT PARAMETERS | GERİYE DEĞER DÖNDÜRMEYEN INT PARAMETRELİ METOTLAR

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region RETURNING METHODS | GERİYE DEĞER DÖNDÜREN METOTLAR

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //*******************************************************************

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region RETURNING METHODS WITH STRING PARAMETERS | GERİYE DEĞER DÖNDÜREN STRING PARAMETRELİ METOTLAR

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion

            #region RETURNING METHODS WITH INT PARAMETERS | GERİYE DEĞER DÖNDÜREN INT PARAMETRELİ METOTLAR

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

            #region GRADING SYSTEM IMPLEMENTATION | NOTLANDIRMA SİSTEMİ UYGULAMASI

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli öğrenci sınavı geçti. Ortalama: " + result;
            //    }
            //    else
            //    {

            //        return student + " isimli öğrenci sınavdan kaldı. Ortalama: " + result;
            //    }
            //}

            //Console.WriteLine(ExamResult("Ali", 24, 41, 55));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));

            #endregion

            Console.Read();
        }
    }
}
