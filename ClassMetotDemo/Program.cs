using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.Adi = "Engin";
            musteri1.HesapNo = 10;

            Musteri musteri2= new Musteri();
            musteri2.Id = 2000;
            musteri2.Adi = "Furkan";
            musteri2.HesapNo = 7;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3000;
            musteri3.Adi = "Pınar";
            musteri3.HesapNo = 13;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4000;
            musteri4.Adi = "İpek";
            musteri4.HesapNo = 21;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

        
            // Object

            MusteriManager musteriManager = new MusteriManager();
            //Ekle

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Ekle(musteriler[i]);
            }

            Console.WriteLine("------------------------------------------------");

            //Sil

            musteriManager.Sil(musteri1);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                Müşteriler                      ");
            Console.WriteLine("-------------------------------------------------");

            //Listele

            foreach (Musteri list in musteriler)
            {
                musteriManager.Listele(list);
                Console.WriteLine("-----------------------------------------");
            }






            Console.ReadKey();
        }

        
    }
    
}
