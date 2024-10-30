using System;

namespace _02.SOLIDPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * SOLID prensipleri, nesne yönelimli programlamada kodun esnek, anlaşılır ve bakımı kolay olmasını sağlayan beş temel ilkedir.
             */
        }

        #region S - SINGLE RESPONSIBILITY PRINCIPLE | TEK SORUMLULUK İLKESİ

        /*
         * Her class'ın yalnızca tek bir sorumluluğu olmalı. Bu sayede, bir değişiklik gerektiğinde yalnızca ilgili class değiştirilir.
         */

        public class Customer
        {
            public string Name { get; set; }
        }

        public class CustomerRepository
        {
            public void AddCustomer(Customer customer)
            {
                // Müşteri ekleme işlemleri
            }
        }

        /*
         * Burada "Customer" class'ı yalnızca müşteri bilgilerini tutarken, "CustomerRepository" veri işlemlerinden sorumludur.
         */

        #endregion

        // ******************************************************************************

        #region O - OPEN/CLOSED PRINCIPLE | AÇIK/KAPALILIK İLKESİ

        /*
         * Class'lar geliştirmeye açık, değişime kapalı olmalıdır. Bu, mevcut kodu değiştirmeden yeni özellikler eklemeyi sağlar.
         */

        /*
         * Burada abstract class kullanılarak ortak bir temel class'ın tanımlanmasını ve türetilen class'ların bu temel class'a göre yapılandırılmasını sağlanır.
         * Aşağıdaki method'da abstract class, alt class'lara ortak property ve method'ları miras bırakır.
         * Abstract class'ların örneği oluşturulamaz, çünkü kendileri eksik yapıdır. Yalnızca türetilen class'ların örnekleri oluşturulur. Yani "Shape" class'ın yalnızca bir şablon olarak kullanılmasını sağlar.
         */
        public abstract class Shape
        {
            // Aşağıdaki abstract method, alt class'ların her birinde farklı şekilde uygulanmak zorundadır. Böylece her şekil, kendi özel hesaplama formülünü uygular.
            public abstract double GetArea();
        }

        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double GetArea() => Math.PI * Radius * Radius;
        }

        /*
         * Yeni bir şekil ekleme için "Shape" class'ını değiştirilmesine gerek kalmadan yeni bir class oluşturulur.
         * Özetle, abstract class kullanımı ile alt class'ların ortak bir çatı altında birleşmesi ve kendilerine özel özelliklerin tanımlanabilmesini sağlar.
         */

        #endregion

        // ******************************************************************************

        #region L - LISKOV SUBSTITUTION PRINCIPLE | LISKOV DEĞİŞTİRME İLKESİ

        /*
         * Bir class'ın alt class'ları (yani subclass), türetildiği class'ın yerine geçebilmelidir. Subclass, base class'ın davranışını bozmayacak şekilde kullanılabilmelidir. 
         */

        public class Rectangle
        {
            /*
             * "virtual" keyword'ü, bir class'ta tanımlanan bir özelliğin veya method'un, türetilen class'larda yeniden tanımlabilir (override edilebilir) olduğunu belirtir.
             * Subclass'ların, base class'taki varsayılan davranışın yerine kendi özel davranışlarını ekleyebilemelerini sağlar kısaca esneklik ve genişletilebilirlik sunar.
             */
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }
        }

        public class Square : Rectangle
        {
            /*
             * "override" keyword'ü subclass'ta base class'taki bir "virtual" veya "abstract" üyenin davranışını değiştirmek için kullanılır. Böylece subclass, base class'tan devraldığı özelliği veya method'u kendi ihtiyaçlarına göre yeniden tanımlayabilir.
             */
            public override int Width { set => base.Width = base.Height = value; }
            public override int Height { set => base.Width = base.Height = value; }
        }
        /*
         * Yukarıdaki örnekte "Square", "Rectangle" gibi davranır, ancak her iki özelliğin değerlerini eşitleyerek çalışır.
         */

        #endregion

        // ******************************************************************************

        #region I - INTERFACE SEGREGATION PRINCIPLE | ARAYÜZ AYRIMI İLKESİ

        /*
         * Class'lar, kullanmadıkları method'lara zorlanmamalıdır. Geniş interface'ler yerine, küçük ve odaklanmış interface'ler oluşturulmalıdır.
         */

        public interface IPrinter
        {
            void Print();
        }

        public interface IScanner
        {
            void Scan();
        }

        public class MultiFunctionPrinter : IPrinter, IScanner
        {
            public void Print() { /* Yazdırma işlemi */ }
            public void Scan() { /* Tarama işlemi */ }
        }

        /*
         * Sadece işlemi yapan bir cihaz, yalnızca "IPrinter" interface'sini kullanabilir.
         */

        #endregion

        // ******************************************************************************

        #region D - DEPENDENCY INVERSION PRINCIPLE | BAĞIMLILIKLARIN TERS ÇEVRİLMESİ İLKESİ

        /*
         * Yüksek seviyeli class'lar, düşük seviyeli class'lara doğrudan bağımlı olmamalıdır. Bunun yerine, interface veya abstraction'lar kullanılarak bağımlılık ters çevirilmelidir.
         */

        public interface IMessageSender
        {
            void SendMessage(string message);
        }

        public class EmailSender : IMessageSender
        {
            public void SendMessage(string message) { /* E-posta gönder */}
        }

        public class Notification
        {
            private readonly IMessageSender _messageSender;

            public Notification(IMessageSender messageSender)
            {
                _messageSender = messageSender;
            }

            public void Notify(string message)
            {
                _messageSender.SendMessage(message);
            }
        }

        /*
         * Burada "Notification" class'ı, e-posta gönderme işlemi için doğrudan "EmailSender" yerine "IMessageSender" interface'sini kullanır.
         */

        #endregion
    }
}
