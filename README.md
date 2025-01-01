# 👩🏼‍💻 C# EĞİTİM KAMPI

Murat Yücedağ'ın [C# Eğitim Kampı](https://youtube.com/playlist?list=PLKnjBHu2xXNPmFMvGKVHA_ijjrgUyNIXr&si=cLyDHRSu0go-YLPt) online kursundan, C# üzerine eğitim aldığım ve öğrenirken yaptıklarımı notlar aldığım repodur.

# Repo İçerikleri:

## 1. Temel Konular | Main Subjects 📚
+ Bu projede yazdırma komutları, string ve int değişkenler bahsedilmiştir. `Console.WriteLine()` yazdırma komutu ile değişkenlerin ekrana yazılışı gösterilmiştir.
+ Temel C# yapılarını ve veri tiplerini anlamak, programlamanın temellerini kavramak için kritik öneme sahiptir.📖

## 2. Değişkenler | Variables 📊
+ Bu projede double ve char değişkenler ve veri girişlerinden bahsedilmiştir. `Console.ReadLine` komutu ile `Parse` metodu kullanımı gösterilmiştir.
+ Değişkenler, program içinde veri saklamayı ve manipüle etmeyi mümkün kılar, bu nedenle veri tiplerinin doğru seçimi önemlidir.🔢

## 3. Karar Yapıları | Making Decision 🧠
+ Bu projede If-Else yapısından ve Switch Case'den bahsedilmiştir.
+ Karar yapıları, programın belirli koşullara göre farklı yollar izlemesini sağlayarak, akış kontrolünü sağlamaktadır.⚖️

## 4. Döngüler | Loops 🔁
+ Bu Projede for ve while döngüleri ve bu döngülerin karar yapıları ile kullanımından bahsedilmiştir.
+ Döngüler, belirli bir işlemin tekrar edilmesi gereken durumlarda programın etkinliğini artırarak kodun tekrarlanmasını önler.🔄

## 5. Yıldızlar Döngü | Loops With Stars 🌟♾️
+ Bu projede yıldız `*` kullanılarak pratikler yapılmıştır ve farklı desenler oluşturulmuştur.
+ Yıldız desenleri oluşturma, döngü ve kontrol yapılarını pekiştirmek için görsel bir yöntem sunar.✨

## 6. Diziler | Arrays 🗂️
+ Bu projede temel dizi örnekleri, dizideki elemanları listeleme, dizi metotları ve kullanıcıdan değer alarak dizi oluşturulmadan bahsedilmiştir.
+ Diziler, birden fazla veriyi aynı anda yönetmeyi kolaylaştırarak veri gruplarını işlemede esneklik sağlar.🗄️

## 7. Foreach Döngüsü | Foreach Loop 🔂
+ Bu projede foreach döngüsünden bahsedilmiştir ve önceki konular da baz alarak örnek yapılmıştır.
+ Foreach döngüsü, koleksiyonlar üzerinde basit ve etkili bir şekilde iterasyon yaparak kodun okunabilirliğini artırır.🔍

## 8. Metotlar | Methods 🛠️
+ Bu projede geriye değer döndüren ve geriye değer döndürmeyen metotlardan bahsedilmiştir. Bu iki tür metota özgü örnekler yapılmıştır.
+ Metotlar, kod tekrarını azaltarak modülerlik sağlar ve belirli görevlerin ayrı birimlerde yönetilmesine imkan tanır.🔧

## 9. Veritabanı Projesi | Database Project 🗃️
+ Bu projede bir C# proje ile SQL veri tabanı uygulamasını Ado.Net kullanarak bağlantı kurulumundan bahsedilmiştir.
+ Veritabanı projeleri, verilerin kalıcı olarak saklanmasını ve işlenmesini sağlayarak dinamik uygulamalar geliştirmede temel bir rol oynar.🗄️

## ✨MODÜL 301

## 10. Veritaban CRUD | Database CRUD 🚀
+ `Create` ➡️ Veritabanına yeni veri ekleme işlemi. `INSERT INTO` sorgusu veya ORM ile yapılır.
+ `Read` ➡️ Verileri okuma ve görüntüleme işlemi. `SELECT` sorgusu ile gerçekleştirilir.
+ `Update` ➡️ Mevcut veriyi güncelleme işlemi. `UPDATE` sorgusu kullanılır.
+ `Delete` ➡️ Veri silme işlemi. `DELETE FROM` sorgusu ile yapılır.

> 💡CRUD işlemlerini veritabanı yönetimi için Entity Framework gibi ORM araçları veya `SqlCommand` gibi class'larla kolayca uygulanabilmektedir.

## 11. Nesne Yönelimli Programlama Modülü | OOP Module: N-Tier Architecture Entity Layer🛠️
+ `Sınıflar | Classes` ➡️ Nesnelerin kalıbı olarak kullanılır. Her class, nesnelerin sahip olduğu özellikleri ve davranışları tanımlar.
+ `Nesneler | Objects` ➡️ Class'lardan türetilen gerçek varlıklardır; class'ların örnekleridir.
+ `Kapsülleme | Encapsulation` ➡️ Verileri ve işlevleri bir class içinde toplayarak gizliliği sağlar.
+ `Kalıtım | Inheritance` ➡️ Bir class'ın başka bir class'ın özelliklerini miras almasını sağlar.
+ `Çok Biçimlilik | Polymorphism` ➡️ Aynı işlemin farklı class'larda farklı biçimlerde uygulanmasını sağlar.
+ `Soyutlama | Abstraction` ➡️ Gereksiz detayları gizleyerek yalnızca gerekli bilgileri öne çıkarır.
> 💡OOP programlamada esneklik sağlar, kodu daha düzenli ve anlaşılır hale getirir.

+ N-Tier Architecture'da Entity Layer (Varlık Katmanı), genellikle yazılım geliştirme sürecinde verilerin temsili ve işlenmesiyle ilgili işlemleri ele alan bir katmandır. Bu katman, uygulamanın temel veri modelini barındırır ve diğer katmanlar arasında veri alışverişini kolaylaştırır.

##### Özellikler:
1. `Veri Temsili:` Uygulamanın işlediği gerçek dünya nesnelerinin (örneğin, Kullanıcı, Sipariş, Ürün) yazılım dünyasındaki temsilini sağlar. Genellikle sınıflar veya yapılar halinde tanımlanır.
2. `Bağımsızlık:` Entity Layer, genellikle uygulamanın iş mantığı ve veri erişiminden bağımsız olarak tasarlanır, böylece diğer katmanlarla minimum bağımlılık yaratır.
3. `Veri Doğrulama ve Özellikler:` Veri üzerinde temel doğrulama kurallarını veya özellikleri içerebilir (örneğin, veri türleri, minimum/maksimum değerler).

##### Kullanım:
+ `Data Transfer Objects (DTO):` Verilerin, farklı katmanlar arasında taşınması için kullanılır.
+ `ORM Entegrasyonu:` Entity Layer genellikle bir ORM (Object-Relational Mapping) aracıyla (ör. Entity Framework, Hibernate) veritabanı tablolarıyla ilişkilendirilir.
+ `Düzenlilik ve Modülerlik:` Uygulamanın modüler olmasını sağlayarak kodun okunabilirliğini ve bakımını artırır.

##### Avantajlar:
+ `Yeniden Kullanılabilirlik:` Aynı varlık sınıfları birden çok katmanda kullanılabilir.
+ `Sadelik:` İş mantığı ve veri erişim mantığını soyutlayarak yalnızca veriyi temsil eder.
+ `Bağımsızlık:` Katmanlar arası bağımlılıkları azaltır, farklı teknolojilerle kolayca entegre olabilir.

<strong>📌`Entity Layer, iyi bir N-Tier Architecture tasarımında kritik bir rol oynar, çünkü tüm sistemin veri modellemesini merkezi bir yerde yönetir.`</strong>

## 12. Nesne Yönelimli Programlama Modülü | OOP Module: Data Access Layer & Context Class 🛠️
### Data Access Layer (DAL)
+ Data Access Layer (Veri Erişim Katmanı), bir uygulamada veritabanıyla etkileşim kurmak için kullanılan bir katmandır. Uygulamanın diğer katmanlarından veri erişim detaylarını soyutlayarak, veritabanı işlemlerinin güvenli ve düzenli bir şekilde gerçekleştirilmesini sağlar.

##### Görevleri:
+ `Veritabanı İşlemleri:` CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirir.
+ `Soyutlama:` Veritabanına erişimle ilgili mantığı iş mantığından ayırır.
+ `Performans Optimizasyonu:` Verimli sorgular oluşturarak uygulamanın performansını artırır.

##### Avantajları 🚀
+ Kodun tekrar kullanılabilirliğini artırır.
+ Veri erişimini yönetmek için merkezi bir yapı sunar.
+ Veritabanı değişikliklerini uygulamanın geri kalanından izole eder.

### Context Class
+ Context Class, genellikle bir ORM (Object-Relational Mapping) aracıyla kullanılır ve uygulamayla veritabanı arasındaki köprüyü sağlar. En yaygın örneği, Entity Framework'te kullanılan `DbContext` sınıfıdır.

##### Görevleri:
+ `Veritabanı Bağlantısı:` Veritabanı ile bağlantıyı yönetir.
+ `Tablo-Model Eşleştirmesi:` Veritabanındaki tablolarla, uygulama modellerini eşleştirir.
+ `Sorgular ve İşlemler:` Veritabanı sorgularının yürütülmesini ve değişikliklerin kaydedilmesini sağlar.

##### Avantajları 🚀
+ Veritabanı işlemlerinin kolayca kodlanmasını sağlar.
+ Birden çok veri kaynağına bağlanmak için genişletilebilir.
+ ORM araçlarının sağladığı avantajlardan yararlanır.

##### Data Access Layer ve Context Class Arasındaki İlişki
+ Context Class, DAL için temel sağlar. Veritabanına bağlantıyı ve modellerle tablolar arasındaki ilişkiyi yönetir.
+ DAL, Context Class kullanarak uygulamanın diğer katmanlarına veritabanı işlemleri için bir API sunar.

<strong>📌`Bu yapı, N-Tier Architecture'ın modülerliğini ve bakım kolaylığını destekler.`</strong>

## 13. Nesne Yönelimli Programlama Modülü | OOP Module: Migration & Abstract 🛠️
### Migration (Veritabanı Geçişleri)
+ Migration, veritabanı şemasındaki (tablolar, kolonlar, ilişkiler) değişiklikleri uygulamanın kod tabanındaki değişikliklerle senkronize etmeyi sağlayan bir yöntemdir. Bu kavram genellikle Entity Framework gibi ORM araçlarında kullanılır.

##### Görevleri:
+ `Şema Yönetimi:` Veritabanı şemasını versiyonlayarak değişiklikleri düzenli bir şekilde uygulamanızı sağlar.
+ `Değişiklik Kaydı:` Tabloların eklenmesi, kolonların değiştirilmesi veya ilişkilerin düzenlenmesi gibi işlemleri kaydeder.
+ `Geri Alma:` Uygulanan değişiklikler gerektiğinde geri alınabilir.

##### Avantajları 🚀
+ Kod ve veritabanı arasında senkronizasyon sağlar.
+ Veritabanı değişikliklerini ekip içerisinde izlenebilir ve yönetilebilir kılar.
+ Otomatik şema oluşturma ve güncelleme sağlar.

### Abstract (Soyutlama)
+ Abstract, nesne yönelimli programlamada kullanılan bir yapı olup, temel olarak soyut sınıflar veya metotlar tanımlamak için kullanılır. Bu yapı, ortak özelliklerin ve davranışların alt sınıflar tarafından zorunlu olarak uygulanmasını sağlar.

##### Soyut Sınıf:
+ `Tanım:` Kendi başına örneklenemez (instance oluşturulamaz). Alt sınıflara temel bir yapı sağlar.
+ `Görev:` Alt sınıflarda uygulanması gereken metotları ve ortak özellikleri tanımlar.

##### Avantajları 🚀
+ Kodun tekrarını önler ve ortak davranışları merkezileştirir.
+ Polimorfizm (çok biçimlilik) sağlar.
+ Alt sınıflar arasında tutarlılığı zorunlu kılar.

##### Data Access Layer ve Context Class Arasındaki İlişki
+ `Migration:` Veritabanı şemasını yönetmek için kullanılır ve kod-veritabanı uyumunu sağlar.
+ `Abstract:` Yazılımda soyutlama yaparak ortak davranışların düzenli bir şekilde alt sınıflar tarafından uygulanmasını sağlar.

<strong>📌`Her iki kavram, farklı alanlarda düzenlilik ve yapı kazandırmayı hedefler. Migration, veri yönetimi odaklıdır; Abstract, yazılımın tasarımı ve modülerliği ile ilgilidir.`</strong>

## 14. ORM Structure: Entity Framework DbFirst & Create Model 🛠️
+ Entity Framework DbFirst ve Model Oluşturma, mevcut bir veritabanından model ve context sınıfları oluşturarak veritabanı ile kod arasında bir bağlantı sağlar. Bu yöntem, veritabanı tasarımının uygulama kodundan önce yapıldığı senaryolarda kullanılır.

### DbFirst Nedir?
+ `Tanım:` Mevcut bir veritabanı şemasını temel alarak Entity Framework modellerini (entity sınıfları ve context sınıfını) otomatik olarak oluşturma yöntemidir.
+ `Kullanım Senaryosu:` Önceden oluşturulmuş bir veritabanı yapısının olduğu durumlarda tercih edilir.
+ `Amaç:` Veritabanındaki tablolar, ilişkiler ve diğer yapılar kodla uyumlu hale getirilir.

### DbFirst Avantajları ve Dezavantajları
#### Avantajları:
1. `Hızlı Başlangıç:` Mevcut veritabanı yapısını hızlıca kod tarafına yansıtabilirsiniz.
2. `Senkrone Olarak Güncelleme:` Veritabanı değişikliklerini yansıtmak için modeli yeniden oluşturabilirsiniz.
3. `Manuel Kodlamayı Azaltır:` Tablolar ve ilişkiler otomatik olarak sınıflara çevrilir.

#### Dezavantajları:
1. `Kod Üzerinde Kontrolün Kısıtlanması:` Otomatik oluşturulan sınıflarda manuel düzenleme yapmak sorunlara yol açabilir.
2. `Geliştirme Sürecinde Esneklik Kaybı:` Veritabanı tasarımı değişirse, tekrar model oluşturmak gerekebilir.

##### DbFirst ve CodeFirst Karşılaştırması
|Özellik|DbFirst|CodeFirst|
|-------|--------|---------|
|Başlangıç Noktası|Veritabanı tasarımı önce yapılır.|Kod yazılarak veritabanı otomatik oluşturulur.|
|Esneklik|Daha az esnek, veritabanı odaklıdır.|Daha esnek, kod odaklıdır.|
|Uygulama Senaryosu|Var olan veritabanını kullanma.|Yeni projelerde, veritabanı tasarımına kodla başlama.|

<strong>📌`DbFirst, mevcut bir veritabanını projeye entegre etmek için ideal bir yöntemdir ve özellikle büyük projelerde zamandan tasarruf sağlar.`</strong>

## 15. Entity Framework Methods & Project 🛠️
Entity Framework (EF), bir .NET nesne-ilişkisel eşleme (ORM) aracıdır ve veritabanı işlemlerini daha kolay bir şekilde yapılmasına olanak saplar. Entity Framework, veritabanı ile etkileşim kurarken kullanılan çeşitli yöntemler sunar.

###### İşte en sık kullanılan EF yöntemlerinin kısa açıklamaları:
##### CRUD İşlemleri
|Metot|Görevi|
|-------|--------|
|Add|Veritabanına yeni bir nesne eklemek için kullanılır.|
|Find|Birincil anahtarına göre bir nesneyi getirir.|
|Update|Mevcut bir nesnenin güncellenmesi için kullanılır. Değişiklikler otomatik olarak izlenir.|
|Remove|Bir nesneyi veritabanından siler.|
|SaveChanges|Yapılan tüm değişiklikleri veritabanına kaydeder.|

##### Sorgulama (Querying)
|Metot|Görevi|
|-------|--------|
|ToList|Bir sorgunun sonucunu liste olarak döner.|
|Where|Belirli bir koşula göre filtreleme yapar.|
|First / FirstOrDefault|İlk kaydı döner veya eğer kayıt yoksa `null` döner.|
|Single / SingleOrDefault|Tek bir kayıt döner; eğer birden fazla kayıt varsa hata fırlatır. Hiç yoksa `null` döner.|
|OrderBy / OrderByDescending|Sıralama işlemleri için kullanılır.|
|Include|İlişkili tabloları yüklemek için kullanılır (Eager Loading).|
|Count|Sorgudan dönen kayıtların sayısını döner.|

##### Asenkron Metotlar
|Metot|Görevi|
|-------|--------|
|AddAsync|Yeni bir nesneyi asenkron olarak ekler.|
|FindAsync|Asenkron olarak birincil anahtara göre nesneyi bulur.|
|ToListAsync|Asenkron olarak liste döner.|
|FirstOrDefaultAsync / SingleOrDefaultAsync|Belirli bir koşula göre ilk kaydı veya tek kaydı asenkron olarak döner.|

<strong>📌`Entity Framework yöntemleri ile hem basit hem de karmaşık veritabanı işlemlerini kolayca gerçekleştirebilirsiniz. Bu yöntemler LINQ ile birlikte güçlü bir araç seti sunar.`</strong>

## 16. Entity Framework: Project 🛠️
CRUD işlemleri uygulanarak Location tablosundaki işlemler yapıldı.

## 17. Entity Framework Methods & Linq 🛠️
LINQ (Language Integrated Query), C# ve .NET dillerinde kullanılan güçlü bir sorgulama mekanizmasıdır. LINQ kullanılarak veritabanları, koleksiyonlar, XML ve diğer veri kaynakları üzerinde kolayca sorgulamalar yapılabilir.

###### İşte LINQ ile ilgili sık sorulan sorular ve bunlara dair kısa açıklamalar:
### Temel LINQ Soruları
1. LINQ nedir?
+ LINQ, verileri sorgulamak için kullanılan bir sorgulama dilidir. SQL'e benzer şekilde çalışır ancak farklı veri kaynaklarını (koleksiyonlar, veritabanları, XML vb.) sorgulamak için kullanılır.

2. LINQ Türleri Nelerdir?

|    |Açıklama|
|-------|--------|
|LINQ to Objects|Koleksiyonlar üzerinde çalışır.|
|LINQ to SQL|SQL Server veritabanları ile çalışır.|
|LINQ to XML|XML verileri ile çalışır.|
|LINQ to Entities|Entity Framework veritabanı sorguları için kullanılır.|

3. LINQ Sorgularında Kullanılan Temel Operatörler Nelerdir?

|    |Açıklama|
|-------|--------|
|Select|Veri seçmek için kullanılır.|
|Where|Filtreleme yapar.|
|OrderBy / OrderByDescending|Sıralama yapar.|
|GroupBy|Gruplama yapar.|
|Join|Farklı veri kaynaklarını birleştirir.|

4. LINQ ile SQL Arasındaki Farklar Nelerdir?
+ SQL sadece veritabanı sorguları için kullanılırken LINQ, her tür veri kaynağı üzerinde çalışabilir.
+ LINQ, C# diline entegredir; bu nedenle IntelliSense gibi özellikler sunar.

### Performans

|Soru|Cevap|
|-------|--------|
| LINQ performansı nasıldır?| LINQ sorguları okunabilirlik açısından avantajlıdır ancak bazı durumlarda performans açısından optimize edilmelidir. Örneğin, büyük veri setlerinde sorgular mümkünse `ToList()` veya `AsEnumerable()` gibi yöntemler kullanmadan yapılmalıdır.|
|LINQ sorguları nasıl optimize edilir?|Filtreleme işlemlerini mümkün olduğunca erken yapılmalı. Gereksiz veri taşımayı önlemek için sadece ihtiyaç duyulan alanlar `Select` ile seçilmeli. Lazy Loading ve Eager Loading arasındaki farklara dikkat edilmeli.|

<strong>📌`LINQ, doğru kullanıldığında oldukça güçlü ve esnek bir araçtır; dolayısıyla bu tür soruları anlamak ve uygulamak, hem teorik hem de pratik bilgiyi içerir.`</strong>

## Ders 17 Case Görevi
![Ekran görüntüsü 2024-11-27 094959](https://github.com/user-attachments/assets/7988bfbf-a626-44a9-bae2-6cde36e52a7c)

## 18. EntityState Komutları, Generic Repostory Class & EF Class 🛠️
### EntityState Komutları 🗂️
+ EntityState, Entity Framework'te bir nesnenin veritabanındaki durumunu kontrol etmek ve işlem yapmak için kullanılır.

+ `Added` ➡️ Veritabanına bir yeni kayıt olarak eklenmesi (INSERT).
+ `Modified` ➡️ Veritabanında güncelleme işlemi yapılması (UPDATE).
+ `Deleted` ➡️ Veritabanından silinmesi (DELETE).
+ `Unchanged` ➡️ Veritabanında hiçbir işlem yapılmaması.
+ `Detached` ➡️ Varlık bağımsız bırakılır, bellekten silinmemesi.

<strong>📌`Not: EntityState, SaveChanges() çağrıldığında uygulanır. Bu, bir varlığın ne şekilde işleneceğini belirler ve veritabanına uygun işlemleri yansıtır.`</strong>

### Generic Repository Class 📦
+ Nedir?
  - Tüm CRUD işlemleri için tekrar eden kodları azaltan, genel bir yapı sağlar.
  - `TEntity` gibi bir tür parametresi ile herhangi bir tablo veya varlık üzerinde çalışabilir.

+ Avantajları 🚀
  - Tekrarı önler.
  - Kodunuzu daha temiz ve yönetilebilir hale getirir.
  - Tüm veri erişim işlemleri tek bir yapı altında toplanır.

+ ###### Örnek:
```
public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}
```

### Entity Framework (FE) Class ⚙️
+ Nedir?
  - Entity Framework (EF), .NET için bir ORM (Object-Relational Mapping) aracıdır. Veritabanı işlemlerini C# nesneleriyle çalışarak kolaylaştırır.

+ EF Sınıflarının Görevleri
  - `DbContext:` Veritabanı bağlantısı ve işlemleri için ana sınıf.
  - `DbSet:` Belirli bir tabloyu temsil eder ve sorgulama/güncelleme işlemleri için kullanılır.
+ ###### Örnek EF Class
```
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionString");
    }
}
```

<strong>📌`Not: Generic Repository Class, EF ile birlikte çalışarak veritabanı işlemlerini daha düzenli ve verimli bir hale getirir.`</strong>

## 19. Business Katmanı & Logic Kurallar 🛠️
### Business Katmanı 🏢
+ Nedir?
  - İş kurallarını ve mantığını içeren uygulama katmanıdır. Uygulamanın veri işleme ve iş kurallarını (business rules) yönetir.

+ Görevleri
  - Veritabanından gelen veriyi işleyip kontrol etmek.
  - İş kurallarını uygulayarak veri akışını sağlamak.
  - UI (Kullanıcı Arayüzü) ve Data Access (Veri Katmanı) arasında bir köprü oluşturmak.
    
<strong>📌`Not: Business katmanı, veritabanı işlemlerinden bağımsızdır ve yalnızca iş mantığına odaklanır.`</strong>

### Logic Kurallar ⚖️
+ Uygulama içinde belirli durumlar için tanımlanan iş mantıkları ve kurallar bütünüdür.
+ Örneğin:
  - Kullanıcıya ait verilerin belirli kriterlere göre doğrulanması.
  - İndirimlerin yalnızca belirli koşullarda uygulanması.
  - Kullanıcı rolleri bazında yetkilendirme.

+ ###### Örnek Logic Kurallar
```
if (order.TotalAmount > 1000)
{
    ApplyDiscount(order, 10); // 1000 TL üzeri siparişlere %10 indirim uygula
}

if (!user.IsActive)
{
    throw new Exception("Kullanıcı aktif değil!"); // Aktif olmayan kullanıcılar için hata fırlat
}
```

<strong>📌`Not: Logic kurallar, hem veritabanından gelen veriler üzerinde kontrol sağlar hem de uygulamanın doğru çalışmasını garanti eder.`</strong>

### Business Katmanı ile Logic Kuralların Uyumu 🤝
Business katmanı, logic kurallarını uygulayarak iş süreçlerini yürütür. Bu yapıyı kullanarak:
+ Kod tekrarını önlenir.
+ İş kurallarını daha kolay yönetilir.
+ Uygulamanız daha okunabilir ve modüler hale gelir.

###### Örnek Business Katmanı
```
public class OrderManager : IOrderService
{
    public void PlaceOrder(Order order)
    {
        if (order.TotalAmount <= 0)
        {
            throw new Exception("Sipariş tutarı sıfırdan büyük olmalı!");
        }
        // İş kurallarını uygula ve siparişi tamamla
    }
}
```

## 20. Dependency Injection (DI) 🛠️
### Nedir?
  - Dependency Injection, bir sınıfın bağımlılıklarını (örneğin, başka bir sınıfı veya servisi) doğrudan kendisinin oluşturması yerine, dışarıdan almasını sağlayan bir tasarım desenidir.
  
### Avantajları 🚀
  - `Gevşek Bağlılık (Loose Coupling):` Sınıflar birbirine sıkı sıkıya bağlı olmaz.
  - `Test Edilebilirlik:` Bağımlılıkların kolayca değiştirilmesi, birimleri daha kolay test edilebilir hale getirir.
  - `Esneklik:` Uygulamanın genişletilmesi ve bakımı kolaylaşır.
 
#### DI Türleri
1. `Constructor Injection:` Bağımlılıklar sınıfın kurucusuna (`constructor`) enjekte edilir.
```
public class OrderManager
{
    private readonly IOrderService _orderService;

    public OrderManager(IOrderService orderService)
    {
        _orderService = orderService;
    }
}
```

2. `Property Injection:` Bağımlılıklar bir özelliğe (`property`) enjekte edilir.
```
public class OrderManager
{
    public IOrderService OrderService { get; set; }
}
```

3. `Method Injection:` Bağımlılıklar bir metoda enjekte edilir.
```
public void PlaceOrder(IOrderService orderService)
{
    orderService.ProcessOrder();
}
```

<strong>📌`Not: Dependency Injection, modern uygulama geliştirmede modülerlik, esneklik ve test edilebilirlik sağlamak için vazgeçilmez bir yaklaşımdır.`</strong>

## 21. Entity'e Özgü Metot Yazmak 🛠️
+ Entity Framework'te (EF) her entity için özelleştirilmiş metotlar yazarak, iş ihtiyaçlarına göre veri işlemleri gerçekleştirebilir. Bu metotlar, genellikle repository veya service sınıflarında tanımlanır ve Entity Framework'ün sunduğu güçlü sorgulama özelliklerinden yararlanır.
+ ###### Örnek: Belirli bir kategorideki ürünleri listeleme, en çok satan ürünleri getirme gibi.

### Kod Örneği 🧑‍💻📋
1. Varlığa Özgü Bir Metot Tanımlama
###### Amaç: Belirli bir kategoriye ait ürünleri getirme.
```
public class ProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    // Belirli bir kategorideki ürünleri getir
    public List<Product> GetProductsByCategory(int categoryId)
    {
        return _context.Products
            .Where(p => p.CategoryId == categoryId)
            .ToList();
    }
}
```

2. Karmaşık İşlemler İçin Metot Yazma
###### Amaç: Stok durumu azalan ürünleri listeleme.
```
public List<Product> GetLowStockProducts(int threshold)
{
    return _context.Products
        .Where(p => p.Stock < threshold)
        .OrderBy(p => p.Stock)
        .ToList();
}
```

### Metotların Örnek Çağrımı 🖥️
```
var productService = new ProductService(new ProductRepository(context));

// Belirli kategori için ürünleri getir
var categoryProducts = productService.GetProductsByCategory(3);

// Stok seviyesi düşük ürünleri getir
var lowStockProducts = productService.GetLowStockProducts(10);
```

### Özet 🗂️
+ Entity'ye özgü metotlar, iş ihtiyaçlarına uygun, temiz ve yönetilebilir kod yazmayı kolaylaştırır. Bu metotlarla birlikte:
  - Karmaşık sorgular bir kez yazılır ve tekrar kullanılabilir hale gelir.
  - Veritabanı işlemleri daha düzenli bir şekilde yönetilir.
  - Performans optimizasyonu sağlanır.

<strong>📌`Bu metotlar, hem kod kalitesini artırır hem de uygulamanın bakımını kolaylaştırır. 🚀`</strong>

## 22. - 23. C# İle Dapper Kullanımı 📜
### Nedir?
+ Dapper, .NET platformu için hafif, hızlı ve esnek bir Micro ORM (Object-Relational Mapper) kütüphanesidir.
+ SQL sorgularını kullanarak veritabanı işlemlerini daha kolay ve performanslı bir şekilde yapmanıza olanak tanır.

### Özellikleri 🌟
+ `Hafif:` Minimal bir kod ile çalışır, ek yük oluşturmaz.
+ `Hızlı:` Performans odaklıdır ve ham ADO.NET kadar hızlıdır.
+ `Esnek:` SQL sorgularını doğrudan yazmanıza izin verir, böylece tam kontrol sağlar.
+ `Kolay Entegrasyon:` Mevcut projelere hızlıca eklenebilir.

### Avantajları 🚀
+ Daha hızlı ve esnek CRUD işlemleri.
+ ORM'lerin karmaşıklığından uzak, kontrolün sizde olduğu bir yapı.
+ Basit kurulum ve kullanım.
+ Desteklediği veri tiplerini otomatik olarak eşler.

###### Dapper Kullanım Örneği
```
using Dapper;
using System.Data.SqlClient;

public class ProductRepository
{
    private readonly string _connectionString = "YourConnectionString";

    public IEnumerable<Product> GetAllProducts()
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string sql = "SELECT * FROM Products";
            return connection.Query<Product>(sql);
        }
    }

    public void AddProduct(Product product)
    {
        using (var connection = new SqlConnection(_connectionString))
        {
            string sql = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
            connection.Execute(sql, product);
        }
    }
}
```

#### Dapper vs. Entity Framework ⚖️
|Özellik|Dapper|Entity Framework|
|-------|------|----------------|
|Performans|Daha hızlı|ORM katmanı nedeniyle daha yavaş|
|SQL Kontrolü|Tam kontrol sağlar|Daha az kontrol|
|Öğrenme Eğrisi|Basit ve hızlı|Daha karmaşık|
|Özelleştirme|Kolayca özelleştirilebilir|ORM yapısına bağlı kalır|

<strong>📌`Dapper, basit ve performans odaklı bir çözüm arayanlar için ideal bir seçenektir. Özellikle büyük ve karmaşık ORM yapıları yerine daha fazla kontrol isteyen projelerde tercih edilir.`</strong>

## 24. - 25. C# ile MongoDb 🍃
### Nedir?
+ MongoDB, açık kaynaklı ve belge tabanlı bir NoSQL veritabanı yönetim sistemidir. Geleneksel ilişkisel veritabanlarından farklı olarak, verileri JSON benzeri belgeler (`document`) şeklinde depolar.

### Özellikleri 🌟
+ `Esnek Yapı:` Şeması olmayan bir yapıya sahiptir, bu nedenle veriler dinamik bir şekilde depolanabilir.
+ `Yüksek Performans:` Büyük veri kümelerinde hızlı okuma ve yazma işlemleri sağlar.
+ `Yatay Ölçeklenebilirlik:` Büyük veri setlerini işlemek için kolayca ölçeklenebilir.
+ `Zengin Sorgu Desteği:` Verileri esnek sorgularla filtreleyebilir ve analiz edebilirsiniz.

### Avantajları 🚀
+ `Hızlı Geliştirme:` Şema tanımlama zorunluluğu olmadığı için değişiklikler daha kolay uygulanır.
+ `Esneklik:` Farklı türde ve yapıda veriler aynı koleksiyonda saklanabilir.
+ `JSON Benzeri Belgeler:` Veriler, programlama dillerindeki veri yapıları ile kolayca uyumludur.

### Temel Kavramlar 🗂️
+ `Database:` Birden fazla koleksiyonun saklandığı ana yapı.
+ `Collection (Koleksiyon):` Tabloya benzer, belgelerin saklandığı yapı.
+ `Document (Belge):` JSON formatına benzer, veri kayıtlarını tutar. Örneğin:
  ```
  {
    "_id": "1",
    "name": "John Doe",
    "age": 30,
    "skills": ["C#", "MongoDB"]
  }
  ```

<strong>📌`MongoDB, özellikle büyük ve hızlı değişen veri setleri ile çalışmak için mükemmel bir seçimdir. Esneklik ve ölçeklenebilirlik isteyen projelerde sıkça kullanılır.`</strong>

## 26. C# ile PostgreSQL 🐘
### Nedir? 
+ PostgreSQL, güçlü bir açık kaynaklı ilişkisel veritabanı yönetim sistemidir (RDBMS). Yüksek performans, geniş özellik seti ve esneklik sunar.

### Özellikleri 🌟
+ `ACID Uyumluluğu:` Veri bütünlüğünü ve güvenilirliğini sağlar.
+ `JSON ve XML Desteği:` Yapılandırılmamış verilerle çalışma imkanı sunar.
+ `Gelişmiş Sorgu Desteği:` Karmaşık sorguları kolayca çalıştırabilir.
+ `Hata Toleransı:` Güçlü kurtarma mekanizmaları sayesinde güvenilirlik sunar.
+ `Uzantılar:` PostGIS gibi uzantılarla işlevsellik artırılabilir.

### Avantaları 🚀
+ `Performanslı:` Büyük veri kümelerinde dahi etkili çalışır.
+ `Esnek:` Geleneksel tablolardan JSON belgelerine kadar farklı veri türlerini destekler.
+ `Açık Kaynak:` Tümüyle ücretsiz ve topluluk desteklidir.
+ `Platform Bağımsız:` Çeşitli işletim sistemlerinde çalışabilir.

### Temel Kavramlar 🗂️
+ `Tablo (Table):` Verilerin satır ve sütunlar halinde düzenlendiği yapı.
+ `Satır (Row):` Verinin tek bir kaydını temsil eder.
+ `Sütun (Column):` Verilerin türünü veya kategorisini belirler.
+ `Primary Key:` Her satırı benzersiz şekilde tanımlayan sütun.
+ `Foreign Key:` İki tablo arasındaki ilişkiyi tanımlar.

### Kullanım 🛠️
+ Veritabanı Oluşturma
```
CREATE DATABASE exampledb;
```

+ Tablo Oluşturma
```
CREATE TABLE users (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100),
    age INT
);
```

+ Veri Ekleme
```
INSERT INTO users (name, age) VALUES ('John Doe', 30);
```

+ Veri Silme
```
DELETE FROM users WHERE id = 1;
```

+ Veri Sorgulama
```
SELECT * FROM users;
```

+ Tablo Güncelleme
```
UPDATE users SET age = 31 WHERE id = 1;
```

### Neden PostgreSQL? 🧐
+ Büyük veri projelerinde etkili.
+ Yüksek güvenlik ve veri bütünlüğü sağlıyor.
+ Topluluk ve kurumsal destek bir arada.

<strong>📌`PostgreSQL, hem esnek hem de güçlü yapısıyla modern uygulamalar için mükemmel bir seçimdir!`</strong>
