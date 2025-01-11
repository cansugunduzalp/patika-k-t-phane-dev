using System;

namespace KitapKütüphanesi
{
    // Kitap sınıfı, kitap nesnelerini temsil eder
    public class Kitap
    {
        // Kitap sınıfının özellikleri (Properties)
        public string Ad { get; set; } // Kitap adı
        public string YazarAdi { get; set; } // Yazarın adı
        public string YazarSoyadi { get; set; } // Yazarın soyadı
        public int SayfaSayisi { get; set; } // Kitap sayfa sayısı
        public string Yayınevi { get; set; } // Yayınevi
        public DateTime KayıtTarihi { get; set; } // Kayıt tarihi (otomatik olarak atandı)

        // Default constructor, parametre almadan kitap nesnesi oluşturulmasını sağlar
        public Kitap()
        {
            // Varsayılan olarak KayıtTarihi, o anki tarih olarak atanır
            KayıtTarihi = DateTime.Now;
        }

        // Parametreli constructor, kitap nesnesi oluşturulurken bilgi girişi yapılmasını sağlar
        public Kitap(string ad, string yazarAdi, string yazarSoyadi, int sayfaSayisi, string yayınevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            SayfaSayisi = sayfaSayisi;
            Yayınevi = yayınevi;
            // KayıtTarihi, nesne oluşturulurken o anki tarih olarak atanır
            KayıtTarihi = DateTime.Now;
        }
    }

    // Ana program
    class Program
    {
        static void Main(string[] args)
        {
            // Parametreli constructor kullanarak bir kitap nesnesi oluşturulur
            Kitap kitap1 = new Kitap("Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");

            // Kitap nesnesinin bilgilerini ekrana yazdırma
            Console.WriteLine($"Kitap Adı: {kitap1.Ad}");
            Console.WriteLine($"Yazar: {kitap1.YazarAdi} {kitap1.YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {kitap1.SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {kitap1.Yayınevi}");
            Console.WriteLine($"Kayıt Tarihi: {kitap1.KayıtTarihi}");

            // Varsayılan constructor kullanılarak bir kitap nesnesi oluşturulur
            Kitap kitap2 = new Kitap();

            // Kitap nesnesinin bilgilerini ekrana yazdırma
            Console.WriteLine("\nVarsayılan Constructor ile Oluşturulan Kitap:");
            Console.WriteLine($"Kitap Adı: {kitap2.Ad}");
            Console.WriteLine($"Yazar: {kitap2.YazarAdi} {kitap2.YazarSoyadi}");
            Console.WriteLine($"Sayfa Sayısı: {kitap2.SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {kitap2.Yayınevi}");
            Console.WriteLine($"Kayıt Tarihi: {kitap2.KayıtTarihi}");
        }
    }
}
