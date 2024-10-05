using System;

namespace L03.MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE

            //System.Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = System.Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //*******************************************************************

            // Burada veri girişi yapılır büyük küçük harf uyumuna dikkat edilmeli, birebir aynı şekilde girilmeli.

            //string capital, country;

            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı veri girişi");
            //}

            //*******************************************************************

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //*******************************************************************

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("1. Sınav: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("2. Sınav: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınav: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //*******************************************************************

            //string city;
            //Console.Write("Lütfen şehri giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            //*******************************************************************

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("BU kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz");
            //}

            #endregion

            #region MOD OPERATIONS | MOD İŞLEMLERİ

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //*******************************************************************

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. sayının 2. sayıya bölümünden kalan değer: " + result);

            //*******************************************************************

            //Console.Write("Lütfen sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çiftir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //////}

            #endregion

            #region EXAMPLE WITH CHAR VARIABLE | CHAR DEĞİŞKENİ İLE ÖRNEK

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("GALATASARAY");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FENERBAHÇE");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("BEŞİKTAŞ");
            //}

            #endregion

            #region MENU APP | MENÜ UYGULAMASI

            //Console.WriteLine("******* C# EĞİTİM KAMPI RESTORANI");
            //Console.WriteLine("");
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------------- ANA YEMEKLER -----------------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Körü Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------------- ÇORBALAR -----------------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------------- PİZZALAR -----------------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Akdeniz");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("3-Tavuklu");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------------- İÇECEKLER -----------------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("----------------- TATLILAR -----------------");
            //    Console.WriteLine("");
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine();
            //}

            #endregion

            #region SWITCH CASE

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi"); break;
            //}

            #endregion

            #region CALCULATOR APP WTIH SWITCH CASE | SWITCH CASE İLE HESAP MAKİNESİ UYGULAMASI

            int num1, num2, result;
            char symbol;

            Console.Write("1. Sayıyı giriniz: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = num1 + num2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = num1 - num2;
                    Console.WriteLine("Çıkarma: " + result);
                    break;
                case '*':
                    result = num1 * num2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = num1 / num2;
                    Console.WriteLine("Sonuç: " + result);
                    break;
                default:
                    Console.WriteLine("Yanlış işlem seçimi");
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
