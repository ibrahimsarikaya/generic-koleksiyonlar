using System;
using System.Collections.Generic;

namespace generic_koleksiyonlar // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>(); // Dizi gibi birşey oluşturduk ve eleman ekledik.

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>(); // Dizi gibi birşey oluşturduk ve eleman ekledik.
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count); // Çıktısı : 5 ->Renklistesinin eleman sayısı 
            Console.WriteLine(sayiListesi.Count); // Çıktısı : 6 ->Sayılistesinin eleman sayısı

            // Foreach ve List.ForEach ile elemanlara erişim.

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi); // Foreach ile sayılistesi dizisine erişip onu sayıya atadık ve console a yazdırdık. Çıktısı : Aşağıya doğru 23 10 4 5 92 34
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk); //Foreach ile renklistesi dizisine erişip onu renk değişkenine atadık ve yazdırdık. Çıktısı : Aşağı doğru Kırmızı Mavi Turuncu Sarı Yeşil
            }
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi)); // Üstteki ForEachler ile aynı görevi yaptılar. Sadece farklı bir kullanım
            renkListesi.ForEach(renk=> Console.WriteLine(renk)); // Üstteki ForEachler ile aynı görevi yaptılar. Sadece farklı bir kullanım

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4); // Sayı Listesinden 4 ü çıkarttık.
            renkListesi.Remove("Yeşil"); // Renk Listesinden Yeşili çıkarttık.
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi)); // ekrana yazdırdık. Çıktısı: 23 10 5 92 34 -> 4 numarası silindi.
            renkListesi.ForEach(renk=> Console.WriteLine(renk)); // ekrana yazdırdık. Çıktısı: Kırmızı Mavi Turuncu Sarı -> Yeşil silidi

            sayiListesi.RemoveAt(0); // 0. indexteki elemanı siler. Yani 23 silindi.
            renkListesi.RemoveAt(1); // 1. indexteki elemanı siler. Yani Mavi silindi.

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde arama
            if (sayiListesi.Contains(10)) // Eğer sayıListesi içersinde 10 u bulursan demek
            {
                Console.WriteLine("10 Liste içerisinde bulundu.");
            }

            //Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Kırmızı")); // renkListesinde Kırmızı yazan elemanın index numarasını verir. Çıktısı : 0

            //Diziyi List'e çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanlarListesi = new List<string>(hayvanlar); // Üstteki diziyi List'e çevirdik.
            hayvanlarListesi.ForEach(animal=> Console.WriteLine(animal)); // Çıktısı : Kedi Köpek Kuş

            //Listeyi nasıl temizleriz?
            hayvanlarListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılaz";
            kullanici1.Yas = 26;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Özcan";
            kullanici2.Soyisim = "Çalışkan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Deniz",
                Soyisim="Arda",
                Yas=24
                
            });

            foreach (var kullanıcı in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yas: "+ kullanıcı.Yas);
            }

            
        }
    }
    public class Kullanıcılar{
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}