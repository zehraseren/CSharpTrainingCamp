using System.Collections.Generic;

namespace CSTC301.EntityLayer.Concrete
{
    public class Category
    {
        /*
         * Bir değişken direkt olarak class'ın içine tanımlanırsa -> Field 
         * Bir değişken yapısı sonunda { get; set; } ile tanımlanıyorsa -> Property
         * Bir değişken method içinde tanımlanırsa yani
          void()
          {
            int x;
          } -> Variable
         */

        public int CategoryId { get; set; } // CodeFirst yaklaşımında primary key olarak alınması için entityNameId şeklinde olmalıdır.
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
