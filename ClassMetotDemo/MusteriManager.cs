using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri İd:" + musteri.Id + "|" + "Adi:"+ musteri.Adi + " Bu bilgilere sahip müşteri sisteme eklendi.");

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri İd:" + musteri.Id + "|" + "Adi:" + musteri.Adi + "|" + "Hesap No:" + musteri.HesapNo);

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " Bu id sahibi sahip müşteri silindi.");

        }
    }


}
