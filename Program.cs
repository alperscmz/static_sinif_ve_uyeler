using System;
namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[]args)
        {
        Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
        Calisan calisan=new Calisan("alper","saçmaözü","IK");
        Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
        Calisan calisan1=new Calisan("ali","veli","IK");
        Calisan calisan2=new Calisan("arda","kural","IK");
        Console.WriteLine("Çalışan Sayısı:{0}",Calisan.CalisanSayisi);
        
        Console.WriteLine("Toplama işlemi sonucu:{0}",Islemler.Topla(200,100));
        Console.WriteLine("Çıkarma işlemi sonucu:{0}",Islemler.Çıkar(200,100));
        }
    }
    class Calisan 
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}
        private string Isim;
        private string Soyisim;
        private string Departman;
        
        static Calisan()
        {
            calisanSayisi=0;
        }
        public Calisan(string ısim, string soyisim, string departman)
        {
            this.Isim = ısim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Çıkar(int sayi1,int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}
