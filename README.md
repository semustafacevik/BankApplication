# BankApplication

*Bu uygulama OOP (Nesneye Yönelik Programlama) dersi için aşağıdaki senaryo baz alınarak geliştirilmiştir.* <br/><br/>

## SENARYO
**1. Yeni Müşteri Ekleme;** Banka işlemlerini yapacak müşterilerin sisteme eklenmesi işlemi yapılacaktır. Aynı müşteri numarası başka müşteriler tarafından kullanılamayacaktır. Ayrıca farklı ayrıcalıklara sahip olan 2 tip müşteri bulunmaktadır. Müşteriler; ticari müşteri, bireysel müşteri olabilmektedir.
<br/><br/>**2. Hesap Açtırma;**
   * Bir müşterinin birden fazla hesabı olabilir.
   * Her hesabı için ayrı ayrı hesap numarası verilmesi gerekir. Aynı hesap numarası birden fazla müşteriye verilmemelidir.
   
<br/>**3. Para Çekme;** Müşteri, para çekecekse ilgili bilgiler girilip çekilen tutar kadar bakiyesinden bakiyesi yetmiyorsa ek hesabını kullanarak para çekme işlemi gerçekleşecektir. Günlük maksimum para çekme limiti 750 tl dir. Daha fazla para çekilmek istendiği takdirde işlem gerçekleşmeyecektir.
<br/><br/>**4. Para Yatırma;** Müşteri, para yatıracaksa ilgili bilgiler girilip yatırılan tutar kadar bakiyesi artacaktır.
<br/><br/>**5. Hesaba Havale;** Müşteri, havale yapacaksa; havale yapacağı kişinin hesabının kayıtlı olması gerekmektedir. Ardından havale tutarı kadar miktar kendi hesabının bakiyesinden eksilecek, gönderdiği kişinin bakiyesi artacaktır. Ayrıca Ticari Müşterilerden havale ücreti kesilmez iken, Bireysel Müşterilerden gönderilecek tutarın %2 oranında havale ücreti kesilmektedir.
<br/><br/>**6. Banka Gelir-Gider Raporu;** Bankanın gelir-giderleri(bankadan giden, gelen ve bankada bulunan toplam para miktarı vb.) hesaplanıp görüntülenecektir. Raporlama için grid bileşeni kullanmanız beklenmektedir.
<br/><br/>**7. Hesap Özeti;** Seçilen bir hesap için belirtilen tarih aralığında hesap özeti görüntülenecektir. Çekilen, yatırılan, havale yapılmışsa kime yapıldığı ve miktarı, başka bir hesaptan havale para geldiyse kimden geldiği ve miktarı gibi bilgiler ve bu işlemlerin tarihleri görüntülenmelidir.
<br/><br/>**8. Hesap Kapama;** İstenilen hesap kapatılabilecektir. Kapama işlemi için hesap bakiyesi 0 olması gerekmektedir.

### Notlar
   * Dosya veya veritabanı işlemleri gerçekleştirilmeyecek, uygulama bellekte çalışacaktır (Array, List).
   * Uygulamanızın bir ana menüsü olmalıdır. Ana menüyü MDI Child form mantığında gerçekleştirebilirsiniz.
