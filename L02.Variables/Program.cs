using System;

namespace L02.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DOUBLE VARIABLES | DOUBLE DEĞİŞKENLER

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

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("Portakal Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("Patates Birim Fiyatı: " + potatoPrice + "₺");
            //Console.WriteLine("Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + "₺ - Gramaj: " + appleGram + "g - Toplam Tutar: " + appleTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + "₺ - Gramaj: " + orangeGram + "g - Toplam Tutar: " + orangeTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + "₺ - Gramaj: " + strawberryGram + "g - Toplam Tutar: " + strawberryTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + "₺ - Gramaj: " + potatoGram + "g - Toplam Tutar: " + potatoTotalPrice + "₺");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + "₺ - Gramaj: " + tomatoGram + "g - Toplam Tutar: " + tomatoTotalPrice + "₺");

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice + "₺");

            #endregion

            #region CHAR VARIABLES | CHAR DEĞİŞKENLER

            // Sezar Şifreleme Örneği
            // String " ile tanımlanırken, char ' ile tanımlanır.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region STRING VARIABLE DATA INPUTS | STRING DEĞİŞKEN VERİ GİRİŞLERİ

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgileri *****");
            //Console.WriteLine();

            //string passengerIdentityNumber, passengerName, passengerSurname, passengerAge, passengerDistrict, passengerCity;

            //Console.Write("T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("T.C. Kimlik No: " + passengerIdentityNumber + " | Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " | " + passengerAge + " | " + passengerDistrict + "/" + passengerCity);
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            #endregion

            #region INT VARIABLE DATA INPUTS AND CONVERSIONS | INT DEĞİŞKEN VERİ GİRİŞLERİ VE DÖNÜŞÜMLERİ

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgidayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region DOUBLE VARIABLE DATA INPUTS | DOUBLE DEĞİŞKEN VERİ GİRİŞLERİ

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region CHAR VARIABLE DATA INPUTS | CHAR DEĞİŞKEN VERİ GİRİŞLERİ

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
