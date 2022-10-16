using System;

namespace yzl8436_degiskenler
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*byte deneme = 255;
            int sayi;
            int sayi_2;
            string isim3;
            string musteriIsmi = "sfsdfsdfsdfsdfsd0";
            char karakter = 'a';

            int mukemmel = 0;

            bool tamamlandiMi = true; //false

            mukemmel = mukemmel + 1;
            musteriIsmi = musteriIsmi + 1;

            DateTime tarih = DateTime.Now;

            //int sayi3 = 0;
            var sayi3 = 0;
            //sayi3 = "mehmet";

            int s1, s2 = 0, s3;*/
            /*int s1;
            int s2;
            int s3;*/

            //merhaba nasılsınız? - tek satırlı açıklama satırı

            /*
              çok
                satırlı açıklama
                satırları
            */

            //-----------------------------------------------------
            //int sayi1 = 32, sayi2 = 45;
            //int sonuc1 = 32 - 45;
            //int sonuc1 = sayi1 - sayi2;
            //int sonuc1 = sayi1 + sayi2;
            //int sonuc1 = sayi1 * sayi2;
            //float sonuc1 = sayi2 / sayi1;
            //float sonuc1 = sayi2 % 7;

            //Console.WriteLine(sonuc1);

            //Console.Write("Merhaba" + tarih);
            //Console.WriteLine(2);

            //------------------------------------------------------
            //ekrandan okunan iki sayının çarpımı
            /*int okunanSayi = 0, okunanSayi2 = 0, sonuc = 0;

            Console.Write("Lütfen ilk sayı giriniz: ");
            okunanSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayı giriniz: ");
            okunanSayi2 = Convert.ToInt32(Console.ReadLine());

            sonuc = okunanSayi * okunanSayi2;
            Console.WriteLine("İşleminizin sonucu: " + sonuc);*/

            //------------------------------------------------------
            //string birleştirme

            //string isim = "ahmet'in yaşı: " + 43; //43
            //Console.WriteLine(isim);

            /*string ad = "ahmet";
            ad += " gürses";

            Console.Write(ad);*/

            //--------------------------------------------------------
            //okunan iki sayıyı birbiriyle carp/bol/topla/cikar

            /*int okunanSayi = 0, okunanSayi2 = 0;

            Console.Write("Lütfen ilk sayıyı giriniz: ");
            okunanSayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            okunanSayi2 = Convert.ToInt32(Console.ReadLine());

            okunanSayi += okunanSayi2; //okunanSayi = okunanSayi + 2;
            Console.WriteLine("Toplama işleminin sonucu: " + okunanSayi);

            okunanSayi *= okunanSayi2; //okunanSayi = okunanSayi * 2;
            Console.WriteLine("Çarpım işleminin sonucu: " + okunanSayi);

            okunanSayi -= okunanSayi2; //okunanSayi = okunanSayi - 2;
            Console.WriteLine("Çıkarım işleminin sonucu: " + okunanSayi);

            okunanSayi /= okunanSayi2; //okunanSayi = okunanSayi / 2;
            Console.WriteLine("Bölme işleminin sonucu: " + okunanSayi);*/

            //artırma operatörleri
            /*var sayi = 2;
            var sonuc = 0;

            string isim = "";
            DateTime tarih;

            //Console.WriteLine(sayi);
            sonuc = sayi++; //sayi+=1 -> sayi = sayi + 1
            Console.WriteLine(sonuc);
            Console.WriteLine(sayi);

            sonuc = ++sayi; //sayi+=1 -> sayi = sayi + 1
            Console.WriteLine(sonuc);

            Console.WriteLine(sayi);*/

            //-------------------------------------------
            //Tür dönüşümleri

            //convert

            /*int sayi = 2131231231;
            //Console.ReadLine();
            var tarih = Convert.ToDateTime("2016-08-03");
            var sayi2 = Convert.ToInt32("1234");
            //var sayi3 = Convert.ToInt32(Console.ReadLine());

            //parse metodu
            int sayi4 = int.Parse("1234");
            //decimal sayi5 = decimal.Parse(Console.ReadLine());

            //cast metodu
            byte sayistr = 122;
            int sayi6 = (int)sayistr;

            //toString
            sayi6.ToString();
            Console.Write(tarih.ToString("dd.MM.yyyy"));*/

            /*int sayi1 = 130;
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi1);*/

            int sayi1 = 10, sayi2 = 20;
            decimal ortalama = (sayi1 + sayi2) / 2;

            Console.WriteLine(ortalama);
            Console.Read();
        }
    }
}