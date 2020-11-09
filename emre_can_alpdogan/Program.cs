using System;

namespace emre_can_alpdogan
{
    class Program
    {

        //Konsoldan okunan 2 sayıdan büyük olanı yazdıram metot.
        public static void BuyukSayi()
        {
            int x, y;
            Console.Write("1.Sayıyı Gir:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sayıyı Gir:");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);
            Console.Read();
        }

        // çalıştığında çarpım tablosunu yazdıran metot.
        public static void CarpimTablosu()
        {
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, (i * j));
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
        //vize ve final notları girilen öğrencinin ortalamsını (0.40, 0.60) bulan metot.
        public static void VizeFinal()
        {
            int vize, final, ort;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50 || final < 50)
                Console.WriteLine("Kaldınız.");
            else
                Console.WriteLine("Geçtiniz.");

            Console.ReadKey();
        }
        
        // Girilen bir kelimenin uzunluğunu bulan metot.
        public static void KelimeUzunBul()
        {
            string kelime;
            Console.Write("kelimeyi giriniz: ");
            kelime = Console.ReadLine();
            string[] kelimeler = kelime.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            {
                Console.WriteLine(kelime);
            }
            Console.ReadKey();
        }

        // Çarpma işlemini toplama kullanarak yapan metot.
        public static void ToplamaIleCarpma()
        {
            int sayi1, sayi2, sonuc = 0;
            Console.Write("1. sayıyı giriniz : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= sayi2; i++)
            {
                sonuc = sayi1 + sonuc;
            }
            Console.WriteLine("Çarpım sonucu : " + sonuc);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            BuyukSayi();
            CarpimTablosu();
            VizeFinal();
            KelimeUzunBul();
            ToplamaIleCarpma();

        }
    }
}
