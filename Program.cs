using System;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SınıfAdı
            // {
            //     [ErişimBelirleyici] [VeriTipi] ÖzellikAdı;
            //     [ErişimBelirleyici] [GeriDönüşTipi] MetotAdı([ParametreListesi])
            //     {
            //         Metot Komutları
            //     }
            // }

            // Erişim Belirleyiciler
            // * public
            // * private
            // * internal
            // * protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 23415634;
            calisan1.Departman = "İnsan Kaynakları";

            calisan1.CalisanBilgileri();

            Console.WriteLine("*************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 25646789;
            calisan2.Departman = "Satış";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı: {0}", Ad);
            Console.WriteLine("Çalışan soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan numarası: {0}", No);
            Console.WriteLine("Çalışanın departmanı: {0}", Departman);
        }
    }
}
