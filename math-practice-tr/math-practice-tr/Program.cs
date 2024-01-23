using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace math_practice_tr
{
    internal class Program
    {
        public static int sayacDogru = 0, sayacYanlis = 0, islem = 0, aksiyon = 0, islemHakkinda = 0, islemLevel = 0, bitirmekIslem = 0;
        public static bool levelKolay = false, levelOrta = false, levelZor = false;

        static void Main(string[] args)
        {
            Console.Clear();
            yazdirMenu();
            if (islem == 1)
            {
                secLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Topla(olusturSayi(), olusturSayi2());
                }
                yazdirNot();
                BitirmekIslem();
                if (bitirmekIslem == 1) { Main(args); }
                else if (bitirmekIslem == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (islem == 2)
            {
                secLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Cikarma(olusturSayi(), olusturSayi2());
                }
                yazdirNot();
                BitirmekIslem();
                if (bitirmekIslem == 1) { Main(args); }
                else if (bitirmekIslem == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (islem == 3)
            {
                secLevel();
                for (int i = 1; i <= 10; i++)
                {

                    Bolme(olusturSayi(), olusturSayi2());

                }
                yazdirNot();
                BitirmekIslem();
                if (bitirmekIslem == 1) { Main(args); }
                else if (bitirmekIslem == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (islem == 4)
            {
                secLevel();
                for (int i = 1; i <= 10; i++)
                {
                    Carpma(olusturSayi(), olusturSayi2());

                }
                yazdirNot();
                BitirmekIslem();
                if (bitirmekIslem == 1) { Main(args); }
                else if (bitirmekIslem == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (islem == 5)
            {
                secLevel();
                Console.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    olusturAksiyon();
                    if (aksiyon == 1)
                    {
                        Topla(olusturSayi(), olusturSayi2());
                        Console.Clear();

                    }
                    else if (aksiyon == 2)
                    {
                        Cikarma(olusturSayi(), olusturSayi2());
                        Console.Clear();

                    }
                    else if (aksiyon == 3)
                    {
                        Bolme(olusturSayi(), olusturSayi2());
                        Console.Clear();

                    }
                    else if (aksiyon== 4)
                    {
                        Carpma(olusturSayi(), olusturSayi2());
                        Console.Clear();

                    }
                }
                yazdirNot();
                BitirmekIslem();
                if (bitirmekIslem == 1) { Main(args); }
                else if (bitirmekIslem == 2) { Environment.Exit(0); }
                else { Main(args); }
            }
            else if (islem == 6)
            {
                Console.Clear();
                Hakkinda();
                if (islemHakkinda == 1)
                {
                    Main(args);
                }
                else if (islemHakkinda == 2)
                {
                    Environment.Exit(0);
                }
            }
            else if (islem == 7)
            {
                Environment.Exit(0);
            }
            else
            {
                Main(args);
            }
            Console.ReadLine();
        }

        public static int yazdirMenu()
        {
            Console.WriteLine("Matematik Pratik'e hoş geldiniz");
            Console.WriteLine();
            Console.WriteLine("[1] Toplama");
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine("[3] Bölme");
            Console.WriteLine("[4] Çarpma");
            Console.WriteLine("[5] Rastgele");
            Console.WriteLine("[6] Uygulama hakkında");
            Console.WriteLine("[7] Çıkış");
            Console.WriteLine();
            Console.WriteLine("Hangi işlemi gerçekleştirmek istiyorsunuz?");
            try
            {
                islem = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
            return islem;
        }
        public static void secLevel()
        {
            Console.Clear();
            Console.WriteLine("[1] Kolay");
            Console.WriteLine("[2] Orta");
            Console.WriteLine("[3] Zor");
            Console.WriteLine();
            Console.WriteLine("Hangi işlemi gerçekleştirmek istiyorsunuz?");
            try
            {
                islemLevel = Convert.ToInt32(Console.ReadLine());
                if (islemLevel == 1)
                {
                    levelKolay = true;
                    levelOrta = false;
                    levelZor = false;
                }
                else if (islemLevel == 2)
                {
                    levelKolay = false;
                    levelOrta = true;
                    levelZor = false;
                }
                else if (islemLevel == 3)
                {
                    levelKolay = false;
                    levelOrta = false;
                    levelZor = true;
                }
                else
                {
                    secLevel();
                }
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static int olusturSayi()
        {
            Random rastgele = new Random(Guid.NewGuid().GetHashCode());
            int rastgeleSayi = 0;
            if (levelKolay == true)
            {
                rastgeleSayi = rastgele.Next(1, 11);
            }
            else if (levelOrta == true)
            {
                rastgeleSayi = rastgele.Next(1, 101);
            }
            else if (levelZor == true)
            {
                rastgeleSayi = rastgele.Next(1, 1001);
            }
            return rastgeleSayi;
        }
        public static int olusturSayi2()
        {
            Random rastgele2 = new Random(Guid.NewGuid().GetHashCode());
            int rastgeleSayi2 = 0;
            if (levelKolay == true)
            {
                rastgeleSayi2 = rastgele2.Next(1, 11);
            }
            else if (levelOrta == true)
            {
                rastgeleSayi2 = rastgele2.Next(1, 101);
            }
            else if (levelZor == true)
            {
                rastgeleSayi2 = rastgele2.Next(1, 1001);
            }
            return rastgeleSayi2;
        }
        public static int olusturAksiyon()
        {
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(1, 5);
            return aksiyon = rastgeleSayi;
        }
        public static void yazdirNot()
        {
            Console.WriteLine("Doğru sayısı: " + sayacDogru);
            Console.WriteLine("Yanlış sayısı: " + sayacYanlis);
        }
        public static void Topla(int sayi, int sayi2)
        {
            Console.Clear();
            Console.WriteLine("[1] Toplama");
            Console.WriteLine();
            Console.Write(sayi + " + " + sayi2 + " = ");
            try
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi + sayi2;
                if (tahmin == sonuc)
                {
                    sayacDogru++;
                }
                else
                {
                    sayacYanlis++;
                }
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void Cikarma(int sayi, int sayi2)
        {
            Console.Clear();
            Console.WriteLine("[2] Çıkarma");
            Console.WriteLine();
            Console.Write(sayi + " - " + sayi2 + " = ");
            try
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi - sayi2;
                if (tahmin == sonuc)
                {
                    sayacDogru++;
                }
                else
                {
                    sayacYanlis++;
                }
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void Bolme(int sayi, int sayi2)
        {
            Console.Clear();
            Console.WriteLine("[3] Bölme");
            Console.WriteLine();
            int sonuc = sayi / sayi2;
            if (sayi % sayi2 == 0)
            {
                Console.Write(sayi + " / " + sayi2 + " = ");
                try
                {
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    {
                        if (tahmin == sonuc)
                        {
                            sayacDogru++;
                        }
                        else
                        {
                            sayacYanlis++;
                        }
                    }

                }
                catch
                {
                    Console.WriteLine("İşlem gerçekleştirilemedi.");
                    if (Console.KeyAvailable == true)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Bolme(olusturSayi(), olusturSayi2());
            }
        }
        public static void Carpma(int sayi, int sayi2)
        {
            Console.Clear();
            Console.WriteLine("[4] Çarpma");
            Console.WriteLine();
            Console.Write(sayi + " x " + sayi2 + " = ");
            try
            {
                int tahmin = Convert.ToInt32(Console.ReadLine());
                int sonuc = sayi * sayi2;
                if (tahmin == sonuc)
                {
                    sayacDogru++;
                }
                else
                {
                    sayacYanlis++;
                }
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static int Hakkinda()
        {
            Console.Clear();
            Console.WriteLine("[6] Hakkında");
            Console.WriteLine();
            Console.WriteLine("Math Pratik, matematik becerilerinizi geliştirmek için tasarlanmış etkileşimli bir C# konsol uygulamasıdır.");
            Console.WriteLine("Eğlenceli ve kullanıcı dostu bir deneyim sunmayı hedeflerken temel aritmetik işlemleri yapmanıza olanak tanır.");
            Console.WriteLine();
            Console.WriteLine("Programcı hakanberkeicellioglu");
            Console.WriteLine();
            Console.WriteLine("LinkedIn: https://www.linkedin.com/in/hakanberkeicellioglu/");
            Console.WriteLine("GitHub: https://github.com/hakanicellioglu");
            Console.WriteLine();
            Console.WriteLine("[1] Menüye dön");
            Console.WriteLine("[2] Çıkış");
            try
            {
                islemHakkinda = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                Hakkinda();
            }
            return islemHakkinda;
        }
        public static void BitirmekIslem()
        {
            Console.WriteLine();
            Console.WriteLine("[1] Menüye dön");
            Console.WriteLine("[2] Çıkış");
            try
            {
                bitirmekIslem = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("İşlem gerçekleştirilemedi.");
                if (Console.KeyAvailable == true)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}