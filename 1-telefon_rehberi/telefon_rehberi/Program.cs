using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace telefon_rehberi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {

            Console.Clear();
            var run = new run();
            Console.WriteLine("1. KİŞİ EKLE\n2. KİŞİLERİ LİSTELE\n3. ADA GÖRE ARA\n4. SİL\n5. ÇIKIŞ");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                run.kisiEkle();
                Menu();
            }
            if (secim == "2")
            {
                run.kisileriListele();
                Menu();
            }
            if (secim == "3")
            {
                Console.Write("Aranacak ismi giirniz : ");
                string metin = Console.ReadLine();
                Kisiler gelenKisi = run.ara(metin);
                if (gelenKisi!=null)
                {
                    Console.WriteLine($"Adı ve Soyadı : {gelenKisi.adSoyad}");
                    Console.WriteLine("------------------------");
                    for (int j = 0; j < gelenKisi.telefon.Length; j++)
                    {
                        Console.WriteLine("Telefon " + (j + 1) + $"     : {gelenKisi.telefon[j]}");
                    }
                    Console.WriteLine("------------------------");

                }
                else { Console.WriteLine($"{metin} isminde bir kayıt bulunamadı!!"); }
                Console.WriteLine("Devam etmek için bir tuşa basın");
                Console.ReadLine();
                Menu();
            }
            if(secim=="4")
            {
                Console.Write("Aranacak ismi giirniz : ");
                string metin = Console.ReadLine();
                run.sil(metin);
                Menu();
            }
        }

    }

    public class Kisiler
    {
        public string adSoyad;
        public string[] telefon;

    }

}
