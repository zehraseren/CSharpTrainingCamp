using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CollectionInitializer
{
    internal class Program
    {
        #region METHOD FOR GENERICS

        //// Generic bir method
        //static T GetMax<T>(T a, T b) where T : IComparable
        //{
        //    return a.CompareTo(b) > 0 ? a : b; // Daha büyük olanı döndür
        //}

        #endregion

        static void Main(string[] args)
        {
            #region 1. ARRAYS | DİZİLER

            /*
             * Array, aynı türdeki veri öğelerini sabit bir boyutta tutan bir veri yapısıdır.
             * Array'lerde, her bir elemana indeks numarasıyla doğrudan erişilebilir.
             * İndeksler sıfırdan başlar, yani ilk elemanın indeksi 0’dır.
             * 
             * Başlıca Özellikleri:
             * 1. Sabit Boyut: Array oluşturulurken boyutu belirlenir ve daha sonra değiştirilemez.
             * 2. Aynı Türde Veriler: Tüm elemanlar aynı veri türünde olmalıdır (örneğin, int[] sadece tamsayıları tutar).
             * 3. Rastgele Erişim: Elemanlara indeks numaralarıyla hızlıca erişilebilir.
             * Array'ler, verilerin sabit bir boyutta saklanması gerektiğinde kullanışlıdır, ancak boyut sabit olduğundan dinamik ihtiyaçlara yanıt veremezler.
             */

            //// Bir tamsayı dizisi tanımlama ve elemanlarına değer atama
            //int[] numbers = new int[5];   // 5 elemanlı bir dizi oluşturulur
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;
            //numbers[4] = 50;

            //// Array'i ekrana yazdırma
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region 2. LIST<T> | GENEL LİSTELER

            /*
             * "List<T>" (Dinamik Liste), C# dilinde kullanılan ve belirli bir türde (generic) öğeler tutan bir veri yapısıdır.
             * "T", listenin hangi türde veri tutacağını belirtir (örneğin, "List<int>" tamsayılar tutarken, "List<string>" metinler tutar.
             * Dinamik bir liste olduğu için, eleman sayısı sabit değildir; ihtiyaca göre eleman eklenebilir veya çıkarılabilir.
             * 
             * Başlıca Özellikleri:
             * 1. Dinamik Büyüme: Eleman eklendikçe kapasitesi otomatik olarak artırılır.
             * 2. Rastgele Erişim: İndeks numarası ile herhangi bir elemana doğrudan erişim sağlanır.
             * 3. Esneklik: Eleman ekleme, çıkarma ve arama gibi işlemler kolayca yapılabilir.
             * "List<T>", array'lerin aksine sabit bir boyuta sahip olmadığı için daha esnek bir kullanım sunar.
            */

            //// List koleksiyonu, dinamik boyutludur ve ekleme/çıkarma yapılabilir.
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, };

            //// Listeye eleman ekleme
            //numbers.Add(6); // [1, 2, 3, 4, 5, 6]

            //// Liste elemanını silme
            //numbers.Remove(3); [1, 2, 4, 5, 6]

            //// Liste üzerinde gezinme
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i); // Output: 1, 2, 4, 5, 6
            //}

            #endregion

            #region 3. DICTIONARY<TKEY, TVALUE> | ANAHTAR-DEĞER ÇİFTİ

            /*
             * "Dictionary<TKey, TValue>", C# dilinde kullanılan ve "anahtar-değer" çiftlerini depolayan bir veri yapısıdır.
             * Her öğe, benzersiz bir anahtar (TKey) ile ilişkilendirilmiş bir değer (TValue) içerir.
             * Anahtarlar benzersiz olmalıdır, ancak değerler tekrar edebilir.
             * 
             * Başlıca Özellikleri:
             * 1. Anahtar-Değer Eşlemesi: Her anahtar, tek bir değere karşılık geli
             * 2. Hızlı Erişim: Anahtara göre doğrudan erişim sağlanabilir, bu da hızlı veri arama sağlar. 
             * 3. Benzersiz Anahtarlar: Aynı anahtar birden fazla kez kullanılamaz, ancak aynı değer birden fazla anahtarla ilişkilendirilebilir.
             * "Dictionary<TKey, TValue>", verileri hızlıca aramak veya eşleştirmek gerektiğinde oldukça kullanışlıdır. Örneğin, bir kullanıcının kimliğiyle (anahtar) ona ait bilgileri (değer) saklayabilirsiniz.
            */

            //// Dictionary, anahtar-değer çiftlerini saklar.
            //Dictionary<int, string> students = new Dictionary<int, string>();

            //// Anahtar ve değer ekleme
            //students.Add(1, "Ahmet");
            //students.Add(2, "Mehmet");
            //students.Add(3, "Ayşe");

            //// Anahtara göre değer alma
            //string student = students[2]; // Output: Mehmet

            //// Dictionary üzerinde gezinme
            //foreach (var std in students)
            //{
            //    Console.WriteLine($"No: {std.Key}. İsim: {std.Value}");
            //}

            #endregion

            #region 4. QUEUE<T> (FIRST IN FIRST OUT)| KUYRUK (İLK GİREN İLK ÇIKAR)

            /*
             * "Queue<T>", C# dilinde kullanılan bir veri yapısıdır ve FIFO (First In, First Out - İlk Giren İlk Çıkar) prensibiyle çalışır.
             * Yani, kuyruğa eklenen ilk eleman, ilk olarak çıkarılır. Bu yapı, verilerin sırayla işlenmesi gereken durumlarda kullanılır, örneğin bir işlem sırasını yönetmek için.
             * 
             * Başlıca Özellikleri:
             * 1. İlk Giren İlk Çıkar: İlk eklenen eleman, ilk olarak kuyruğun başından çıkar.
             * 2. Eleman Ekleme (Enqueue): Yeni eleman kuyruğun sonuna eklenir.
             * 3. Eleman Çıkarma (Dequeue): Mevcut eleman kuyruğun başından çıkarılır.
             * "Queue<T>", verilerin sırayla işlendiği, örneğin görev sıralama veya işlem kuyruğu gibi durumlarda kullanılır.
            */

            //// Queue, FIFO mantığı ile çalışır
            //Queue<string> queue = new Queue<string>();

            //// Kuyruğa eleman ekleme (Enqueue)
            //queue.Enqueue("Ali");
            //queue.Enqueue("Veli");
            //queue.Enqueue("Ayşe");

            //// Kuyruktan eleman çıkarma (Dequeue)
            //string firstOut = queue.Dequeue(); // Ali çıkar

            //// Kuyruğun en başındaki elemanı görüntüleme
            //string nextInLine = queue.Peek(); // Veli

            //// Kuyruk üzerinde gezinme
            //foreach(var person in queue)
            //{
            //    Console.WriteLine(person); // Output: Veli, Ayşe
            //}

            #endregion

            #region 5. STACK<T> (LAST IN FIRST OUT) | YIĞIN (SON GİREN İLK ÇIKAR)

            /*
             * "Stack<T>" (Son Giren İlk Çıkar - LIFO, Last In First Out), verilerin son eklenenin ilk çıkarılacağı bir veri yapısıdır.
             * Bu yapıda veri ekleme (push) ve çıkarma (pop) işlemleri sadece üstten (stack’in tepesinden) yapılır.
             * İki temel işlem vardır:
             * 1. Push: Bir veriyi yığının tepesine ekler.
             * 2. Pop: Yığının tepesindeki veriyi çıkarır.
             * "Stack<T>", geri alma işlemleri veya çağrı yığınları (function call stacks) gibi senaryolarda kullanılır.
            */

            //// Stack, LIFO mantığı ile çalışır
            //Stack<string> stack = new Stack<string>();

            //// Yığına eleman ekleme (Push)
            //stack.Push("Kitap 1");
            //stack.Push("Kitap 2");
            //stack.Push("Kitap 3");

            //// Yığından eleman çıkarma (Pop)
            //string topItem = stack.Pop(); // Kitap 3 çıkar

            //// Yığının en üstündeki elemanı görüntüleme (Peek)
            //string nextItem = stack.Peek(); // Kitap 2

            //// Yığın üzerinde gezinme
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item); // Kitap 2, Kitap 1
            //}

            #endregion

            #region 6. HASHSET<T> | BENZERSİZ ÖĞELER

            /*
             * "HashSet<T>", koleksiyondaki öğelerin benzersiz olmasını sağlayan bir veri yapısıdır.
             * Aynı değeri birden fazla eklemeye çalışıldığında sadece bir tanesini tutar ve diğerini yok sayar.
             * Veriler, genellikle hızlı erişim için hash fonksiyonları kullanılarak organize edilir.
             * Öğeler sıralı değildir ve indeks tabanlı erişim sunmaz, ancak veri ekleme, çıkarma ve arama işlemleri hızlıdır.
             * Benzersiz öğelerin tutulması gereken durumlar için idealdir (örn. kimlik numaraları, kullanıcı adları).
             * 
             * Başlıca Özellikleri:
             * 1. Add: HashSet'e yeni bir öğe ekler. Eğer öğe zaten varsa eklemez.
             * 2. Remove: Belirli bir öğeyi setten çıkarır.
             * 3. Contains: Belirli bir öğenin HashSet'te olup olmadığını kontrol eder.
             * 
             * Avantajları:
             * 1. Veriye hızlı erişim sağlar (ortalama O(1) zaman karmaşıklığı).
             * 2. Benzersiz öğelerle çalışmayı otomatik olarak garanti eder.
             * 
             * Dezavantajları:
             * 1. Veriler sıralı değildir.
             * 2. Hash fonksiyonu karmaşıklığına bağlı olarak performans dalgalanmaları olabilir.
            */

            // HashSet, benzersiz öğeleri saklar
            //HashSet<int> uniqueNumbers = new HashSet<int>();

            //// HashSet'e eleman ekleme
            //uniqueNumbers.Add(1);
            //uniqueNumbers.Add(2);
            //uniqueNumbers.Add(2); // Tekrar eden elemanı eklemez
            //uniqueNumbers.Add(3);

            //// HashSet üzerinde gezinme
            //foreach (var number in uniqueNumbers)
            //{
            //    Console.WriteLine(number); // Output: 1, 2, 3
            //}

            #endregion

            #region 7. LINKEDLIST<T> | BAĞLI LİSTE

            /*
             * "LinkedList<T>", her bir elemanın (düğüm) bir sonraki elemana işaret ettiği, dinamik bir veri yapısıdır.
             * Her düğüm iki bileşenden oluşur: veri ve bir sonraki düğümün adresi (bağlantı).
             * LinkedList, eleman ekleme ve silme işlemlerinde esneklik sağlar, özellikle baştan ve sondan hızlı ekleme/silme işlemleri için idealdir.
             * Ancak, rastgele erişim yavaştır çünkü belirli bir elemana ulaşmak için düğümler sırasıyla dolaşılır (dinamik veri yapılarında, sabit bir boyut gerektirmeyen ve sık ekleme/silme işlemi yapılan durumlarda).
             * Bu yapılar, farklı kullanım senaryolarına uygun olacak şekilde veriyi organize eder ve belirli işlemleri optimize eder.
             * 
             * Başlıca Özellikleri:
             * 1. Dinamik Yapı: Elemanlar birbirine düğümlerle bağlıdır; her düğüm, bir veri ve bir sonraki düğüme referans içerir.
             * 2. Add: Yeni bir düğüm ekler (başta, sonda veya belirli bir pozisyonda).
             * 3. Remove: Belirli bir düğümü listeden çıkarır.
             * 4. Traversal: Listeyi baştan sona dolaşma (ilk elemandan son elemana kadar sırayla erişim).
             * 
             * Avantajları: 
             * 1. Başta ve sonda hızlı ekleme ve silme (O(1) zaman karmaşıklığı).
             * 2. Boyutu esnektir, eklenip çıkarılan elemanlara göre dinamik olarak büyür veya küçülür.
             * 
             * Dezavantajları:
             * 1. Rastgele erişim yavaştır, belirli bir düğüme ulaşmak için sırayla tüm düğümleri dolaşmak gerekir (O(n) zaman karmaşıklığı).
             * 2. Her düğüm, veri ve bağlantı bilgileri tuttuğu için ekstra bellek gerektirir. 
            */

            //// LinkedList, öğelerin birbirine düğümler ile bağlı olduğu bir listedir.
            //LinkedList<int> linkedList = new LinkedList<int>();

            //// Listeye başa ve sona eleman ekleme
            //linkedList.AddFirst(10);
            //linkedList.AddLast(20);
            //linkedList.AddLast(30);

            //// Liste üzerinde gezinme
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item); // Output: 10, 20, 30
            //}

            //// İlk düğümü bulma ve silme
            //LinkedListNode<int> firstNode = linkedList.First;
            //linkedList.Remove(firstNode); // 10 çıkar

            #endregion

            #region 8. OBSERVABLECOLLECTION<T> | DEĞİŞİKLİK İZLENEBİLİR KOLEKSİYON

            /*
             * "ObservableCollection<T>", içindeki öğelerdeki değişiklikleri otomatik olarak izleyen ve bu değişiklikleri dinleyicilere bildiren bir koleksiyon türüdür.
             * Bu yapı, özellikle kullanıcı arayüzü uygulamalarında veri bağlama (data binding) senaryolarında yaygın olarak kullanılır.
             * 
             * Başlıca Özellikleri:
             * 1. Değişiklik Bildirimi: Koleksiyona öğe eklendiğinde, çıkarıldığında veya güncellendiğinde, ilgili değişiklikler otomatik olarak izleyen bileşenlere (örneğin, kullanıcı arayüzü elemanlarına) bildirilir.
             * 2. Dinamik Güncelleme: Koleksiyondaki öğelerin sayısı ve durumu değiştiğinde, bağlanan arayüz bileşenleri otomatik olarak güncellenir.
             * 3. Kullanım Alanı: Genellikle WPF (Windows Presentation Foundation) ve diğer MVVM (Model-View-ViewModel) mimarilerine sahip uygulamalarda kullanılır.
             * 
             * "ObservableCollection<T>", kullanıcı arayüzünde veri güncellemelerini kolaylaştırarak, geliştiricilerin daha etkileşimli ve dinamik uygulamalar oluşturmasına olanak tanır.
            */

            //// ObservableCollection, değişikliklerin izlenebilir olduğu bir koleksiyondur.
            //ObservableCollection<string> items = new ObservableCollection<string>();

            //// Koleksiyonun değişikliklerini izlemek için event kullanılır.
            //items.CollectionChanged += (sender, e) =>
            //{
            //    if (e.Action == NotifyCollectionChangedAction.Add)
            //    {
            //        Console.WriteLine($"Yeni eleman eklendi: {e.NewItems[0]}");
            //    }
            //    else if (e.Action == NotifyCollectionChangedAction.Remove)
            //    {
            //        Console.WriteLine($"Eleman silindi: {e.OldItems[0]}");
            //    }
            //};

            //// Eleman ekleme
            //items.Add("Elma"); // Output: Yeni eleman eklendi: Elma
            //items.Add("Armut"); // Output: Yeni eleman eklendi: Armut

            //// Eleman silme
            //items.Remove("Elma"); // Eleman silindi: Elma

            // Yukarıdaki örnekte koleksiyonda bir eleman eklendiğinde veya silindiğinde "CollectionChanged" tetiklenir. "NotifyCollectionChangedEventHandler" türünde bir geri çağırma (callback) fonksiyonuyla birlikte kullanılır. Bu olay, koleksiyon değişikleri hakkında bilgi sağlar.

            #endregion

            #region 9. SORTEDLIST<TKEY, TVALUE> & SORTEDDICTIONARY<TKEY,TVALUE> | SIRALI ANAHTAR-DEĞER ÇİFTİ
            /*
             * "SortedList<TKey, TValue> & SortedDictionary<TKey, TValue>", anahtar-değer çiftlerini saklayan ve bu çiftleri anahtara göre sıralı bir şekilde tutan bir koleksiyon türüdür (örneğin sıralı veritabanları veya yapılandırma ayarları gibi senaryolar için idealdir).
             * 
             * Başlıca Özellikleri:
             * 1. Anahtara Göre Sıralama: Elemanlar, eklenme sırasında otomatik olarak anahtar değerlerine göre sıralanır, bu sayede her zaman sıralı bir görünüm sunar.
             * 2. Hızlı Erişim: Anahtarlar üzerinden değerlerine hızlı erişim sağlar; arama, ekleme ve silme işlemleri genellikle O(log n) zaman karmaşıklığına sahiptir.
             * 3. Dinamik Boyut: Koleksiyonun boyutu dinamik olarak değişebilir; yeni anahtar-değer çiftleri eklenebilir veya mevcut olanlar çıkarılabilir.
             * 
             * "SortedList<TKey, TValue> & SortedDictionary<TKey, TValue>", hem anahtar-değer çiftlerini sıralı bir biçimde tutarak hem de hızlı erişim sağlayarak veri yönetimini kolaylaştırır.
            */

            //// SortedList & SortedDictionary, anahtar-değer çiftlerini sıralı olarak saklar.
            //SortedList<int, string> sortedList = new SortedList<int, string>();

            //// Anahtar-değer ekleme
            //sortedList.Add(3, "Üç");
            //sortedList.Add(2, "İki");
            //sortedList.Add(1, "Bir");

            //// SortedList üzerinde gezinme
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}

            //// Output:
            //// Key: 1, Value: Bir
            //// Key: 2, Value: İki
            //// Key: 3, Value: Üç

            #endregion

            // ******************************************************************************

            #region SORTEDLIST VS SORTEDDICTIONARY | SORTEDLIST VE SORTEDDICTIONARY FARKI

            /*
             * SortedList<TKey, TValue> ve SortedDictionary<TKey, TValue>, anahtar-değer çiftlerini sıralı bir şekilde saklayan iki koleksiyon türüdür. Ancak, aralarında önemli farklar vardır:
             * 
             * 1. Veri Yapısı: 
             *  - SortedList<TKey, TValue>:
             *      - İçinde key-value çiftleri için bir array kullanılır.
             *      - Array, key'ler sıralı bir biçimde tutulur. Sıralı listeyi hafızada daha az yer kaplayacak şekilde tutar.
             *  - SortedDictionary<TKey, TValue>:
             *      - Key-value çiftlerini saklamak için bir ağaç yapısı (genellikle Red-Black Tree) kullanılır.
             *      - Ağaç yapısı, elemanların dinamik olarak eklenmesi ve çıkarılması sırasında daha iyi performans sağlar.
             *  
             * 2. Performans:
             *  - SortedList<TKey, TValue>:
             *      - Ekleme ve silme işlemleri, dizinin boyutuna bağlı olarak O(n) zaman karmaşıklığına sahiptir, çünkü dizinin sıralı yapısını korumak için elemanların kaydırılması gerekir.
             *      - Key'lare erişim (get) işlemleri O(1) zaman karmaşıklığına sahiptir, bu da onu okuma işlemleri için hızlı hale getirir.
             *  - SortedDictionary<TKey, TValue>:
             *      - Ekleme, silme ve erişim (get) işlemleri O(log n) zaman karmaşıklığına sahiptir. Bu, daha büyük koleksiyonlarda daha iyi performans sağlar.
             *  
             * 3. Kapasite:
             *  - SortedList<TKey, TValue>:
             *      - Önceden belirlenmiş bir kapasiteye sahiptir ve bu kapasite aşılırsa, dizinin yeniden boyutlandırılması gerekir.
             *  - SortedDictionary<TKey, TValue>:
             *      - Dinamik bir yapı olduğu için, eleman sayısı arttıkça büyüyebilir.
             *  
             * 4. Kullanım Senaryoları
             *  - SortedList<TKey, TValue>:
             *      - Daha az öğe ile çalışırken ve hızlı okuma işlemlerine ihtiyaç duyulduğunda tercih edilir.
             *  - SortedDictionary<TKey, TValue>:
             *      - Daha fazla öğe ile çalışırken ve ekleme/silme işlemlerinin sıklıkla yapıldığı durumlarda tercih edilir.
             * 
             * Özet olarak
             *      - SortedList<TKey, TValue>, hafıza açısından daha verimli ancak ekleme/silme işlemlerinde yavaş, sıralı bir dizi yapısına dayanır.
             *      - SortedDictionary<TKey, TValue> ise daha esnek bir yapı sunar, dinamik olarak büyür ve daha iyi performans sağlar, ancak daha fazla bellek kullanabilir.
             */

            #endregion

            // ******************************************************************************

            #region 1. GENERICS

            /*
             * "Generics", bir programlama dilinde türleri (type) soyutlama ve parametreleştirme imkanı sağlayan bir özelliktir.
             * Bu sayede, belirli bir tür yerine genel bir tür belirleyerek class, method veya interface'lerin tanımlanmasına olanak tanır.
             * 
             * Başlıca Özellikleri:
             * 1. Tür Güvenliği: Generics, derleme zamanı tür denetimi sağlar, bu da tür hatalarını en aza indirir.
             * 2. Kodun Yeniden Kullanımı: Farklı türlerdeki verilerle çalışabilen class'lar ve method'lar oluşturarak kodun tekrar kullanımını artırır.
             * 3. Performans: Generics kullanımı, boxing ve unboxing işlemlerini azaltarak performansı artırabilir.
             * 
             * "Generics", esnek ve güçlü bir programlama yapısı sunarak, daha güvenli ve yeniden kullanılabilir kod yazmayı kolaylaştırır.
            */

            //int maxInt = GetMax(10, 20); // Integer
            //Console.WriteLine($"En büyük tam sayı: {maxInt}"); // 20

            //double maxDouble = GetMax(5.5, 2.3); // Double
            //Console.WriteLine($"En büyük ondalıklı sayı: {maxDouble}");

            #endregion

            #region 2. LINQ (LANGUAGE INTEGRATED QUERY)

            /*
             * "LINQ", .NET platformunda yer alan bir özellik olup, verilerle etkileşimde bulunmayı kolaylaştıran bir sorgulama dilidir.
             * LINQ, koleksiyonlar, veritabanları, XML ve diğer veri kaynakları üzerinde sorgular yazmayı sağlar.
             * 
             * Başlıca Özellikleri:
             * 1. Sorgu Yazma Kolaylığı: LINQ, verilerle etkileşimde bulunmak için SQL benzeri bir sözdizimi kullanır, bu da sorguları yazmayı ve okumayı kolaylaştırır.
             * 2. Veri Kaynağı Bağımsızlığı: Farklı veri kaynaklarından (örneğin, array, liste, database) veri çekmeyi mümkün kılar.
             * 3. Tür Güvenliği: LINQ, derleme zamanında tür denetimi yaparak, tür hatalarını en aza indirir.
             * 4. Fonksiyonel Programlama Desteği: LINQ, lambda ifadeleri ve yüksek düzeyli işlevler kullanarak fonksiyonel programlama yaklaşımlarını destekler.
             * 
             * "LINQ", verilerle çalışmayı daha verimli, okunabilir ve anlaşılır hale getirerek, geliştiricilerin uygulama geliştirme sürecini hızlandırır.
            */

            // Örnek bir liste
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //// LINQ kullanılarak çift sayıları filtreleme
            //var evenNumbers = numbers.Where(x => x % 2 == 0);

            //// Filtrelenmiş listeyi
            //Console.WriteLine("Çift Sayılar:");
            //foreach (var number in evenNumbers)
            //{
            //    Console.WriteLine(number); // 2, 4, 6, 8, 10
            //}

            //// LINQ ile toplama işlemi
            //var total = numbers.Sum();
            //Console.WriteLine($"Toplam: {total}"); // Output: 55

            #endregion

            #region 3. IENUMERABLE<T>

            /*
             * "IEnumerable<T>", .NET Framework'te bulunan bir arayüzdür ve koleksiyonların (örneğin, arrays, lists ve diğer koleksiyonlar) sıralı bir biçimde gezilmesine olanak tanır.
             * Bu arayüz, yalnızca GetEnumerator() yöntemini içerir, bu da koleksiyon üzerindeki öğeleri döngü ile geçmek için bir IEnumerator<T> döndürür.
             * 
             * Başlıca Özellikleri:
             * 1. Veri Gezintisi: IEnumerable<T>, koleksiyon öğeleri üzerinde foreach döngüsü ile gezinmeyi sağlar.
             * 2. Temel Koleksiyon Arayüzü: Diğer koleksiyon arayüzleri (örneğin, IList<T>, ICollection<T>) gibi daha karmaşık yapılar, IEnumerable<T>'den türetilir, bu da onu temel bir yapı haline getirir.
             * 3. Deferred Execution (Gecikmeli İcra): LINQ sorguları ile birlikte kullanıldığında, verilerin yalnızca ihtiyaç duyulduğunda işlenmesini sağlar.
             * 
             * "IEnumerable<T>", koleksiyonlarla çalışırken kolay ve esnek bir yöntem sunarak, veri manipülasyonu ve sorgulama işlemlerini basit hale getirir.
             * 
             * "GetEnumarator()" method'u, koleksiyondaki öğelerin sıralı bir şekilde gezilmesini sağlar. 
             * 
             * Temel Özellikleri:
             * 1. Döngü Oluşturma: GetEnumerator() method'u, koleksiyonun üzerinde iterasyon (döngü yapma) yapmak için kullanılır. Bu method çağrıldığında, koleksiyon üzerinde bir iteratör (yani bir "gezgin") oluşturur.
             * 2. IEnumerator<T> Arayüzü: Bu method IEnumerator<T> türünde bir nesne döndürür. IEnumerator<T> arayüzü, koleksiyonun üzerinde gezinmek için gerekli olan MoveNext(), Reset() ve Current gibi method ve özellikleri içerir:
             *      - MoveNext(): Geziniciyi bir sonraki öğeye ilerletir. Eğer koleksiyonun sonuna gelinirse, false döner.
             *      - Reset(): Geziniciyi koleksiyonun başlangıcına döndürür.
             *      - Current: Şu anda geziniyorken erişilen öğeyi temsil eder.
             * 3. Foreach Döngüsü ile Kullanım: GetEnumerator() method'u genellikle foreach döngüsü ile birlikte kullanılır. "foreach" döngüsü, koleksiyonun üzerinde kolayca geçiş yapmayı sağlar.
            */

            //List<string> fruits = new List<string> { "Apple", "Banana", "Strawberry" };

            //// GetEnumarator() method'u kullanarak koleksiyon üzerinde döngü
            //IEnumerator<string> enumerator = fruits.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    string fruit = enumerator.Current;
            //    Console.WriteLine(fruit);
            //}

            // ******************************************************************************

            //// Bir IEnumerable koleksiyonu
            //IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //// IEnumarable üzerinde gezinme
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number); // Output: 1, 2, 3, 4, 5
            //}


            #endregion

            #region 4. ICOLLECTION<T>

            /*
             * "ICollection<T>", .NET Framework'te bulunan bir arayüzdür ve koleksiyonların temel özelliklerini tanımlar.
             * Bu arayüz, koleksiyon üzerinde ekleme, çıkarma ve sayım gibi temel işlemleri gerçekleştirmek için gereken yöntemleri içerir.
             * 
             * Başlıca Özellikleri:
             * 1. Temel Koleksiyon İşlemleri: Add(), Remove(), Clear() gibi yöntemlerle öğe ekleme, çıkarma ve koleksiyonu temizleme işlemlerini destekler.
             * 2. Sayı Kontrolü: Koleksiyondaki öğe sayısını döndüren Count özelliğine sahiptir.
             * 3. Veri Gezintisi: IEnumerable<T> arayüzünden türediği için, koleksiyon üzerinde foreach döngüsü ile gezinmeyi de sağlar.
             * 4. Kopyalama Desteği: Koleksiyondaki öğeleri başka bir dizinin içine kopyalamak için CopyTo() yöntemini içerir.
             * 
             * "ICollection<T>", koleksiyonlar üzerinde temel işlemleri gerçekleştirmek için gereken yapı taşlarını sunarak, veri yönetimini ve manipülasyonunu kolaylaştırır.
            */

            //// ICollection arayüzünü implement eden bir koleksiyon
            //ICollection<string> fruits = new List<string>();

            //// Eleman Ekleme
            //fruits.Add("Apple");
            //fruits.Add("Banana");
            //fruits.Add("Strawberry");

            //// Koleksiyonun boyutunu alma
            //Console.WriteLine($"Meyve sayısı: {fruits.Count}"); // Output: Meyve sayısı: 3

            //// Koleksiyon üzerinde gezinme
            //foreach (var fruit in fruits)
            //{
            //    Console.WriteLine(fruit); // Output: Apple, Banana, Strawberry
            //}

            //// Elelman Silme
            //fruits.Remove("Banana");
            //Console.WriteLine($"Meyve sayısı: {fruits.Count}"); // Output: Meyve sayısı: 2

            #endregion

            // Özet olarak:
            // 1. Generics: Tür güvenliğini artırarak farklı türlerde verilerle çalışmayı sağlar.
            // 2. LINQ: Koleksiyonlar üzerinde kolay ve okunabilir sorgular yazmayı sağlar.
            // 3. IEnumerable<T>: Koleksiyonların tekrarlanabilir olmasını sağlar, foreach döngüsü ile kullanımda yaygındır.
            // 4. ICollection<T>: Koleksiyonların temel özelliklerini tanımlar, eleman ekleme ve çıkarma gibi işlemleri destekler.

            Console.Read();
        }

        #region ADDITION WITH IENUMERABLE

        //static int GetSum(IEnumerable<int> nums)
        //{
        //    int sum = 0;

        //    foreach (var num in nums)
        //    {
        //        sum += num;
        //    }
        //    return sum;
        //}

        #endregion
    }
}
