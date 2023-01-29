using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telefon_rehberi
{


    public class run
    {
        
         static Kisiler[] Kisi = new Kisiler[0];
         
        public void kisiEkle()
        {
            Console.Clear();
            Kisiler k = new Kisiler();
            Console.Write("Adı ve Soyadı : ");
            k.adSoyad = Console.ReadLine();
          
                Console.Write("kac telfon numarası girilecek : ");
                int telAdet =Convert.ToInt32( Console.ReadLine());
                Array.Resize(ref k.telefon, telAdet);
                for (int i = 0; i < k.telefon.Length; i++)
                {
                    Console.Write("Telefonu(" + (i+1) + ") : ");
                    k.telefon[i] = Console.ReadLine();
                }
            Array.Resize(ref Kisi, Kisi.Length + 1);
            Kisi[Kisi.Length - 1] = k;
            Console.WriteLine("1 kayıt eklendi");
            Console.WriteLine("Devam etmek için bir tuşa basın");
            Console.ReadLine();

        }
        public void kisileriListele()
        {
            Console.Clear();
            for (int i = 0; i < Kisi.Length; i++)
            {
                Console.WriteLine($"Adı ve Soyadı : {Kisi[i].adSoyad}");
                for (int j = 0; j <Kisi[i].telefon.Length; j++)
                {
                    Console.WriteLine("Telefon "+(j+1)+ $"     : {Kisi[i].telefon[j]}");
                }
               
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Devam etmek için bir tuşa basın");
            Console.ReadLine();
        }

        public Kisiler ara(string ad)
        {
            Console.Clear();
            for (int i = 0; i < Kisi.Length; i++)
            {
                if (Kisi[i].adSoyad == ad)
                {
                    return Kisi[i];
                }
            }
            return null; ;
        }
        public void sil(string ad)
        {
            int varYok = 0;
            for (int i = 0; i < Kisi.Length; i++)
            {
                if (Kisi[i].adSoyad == ad)
                {
                    if ((i + 1) < Kisi.Length)
                    {
                        for (int j = i; j < Kisi.Length-1; j++)
                        {
                            Kisi[j] = Kisi[j + 1];
                           
                        }

                        Kisi[Kisi.Length - 2] = Kisi[Kisi.Length - 1];
                        Kisi[Kisi.Length - 1] = null;
                        Array.Resize(ref Kisi, Kisi.Length - 1);
                        varYok = 1;
                        Console.WriteLine($"{ad} isnindeki kayıt silindi!!");
                        Console.WriteLine("Devam etmek için bir tuşa basın");
                        Console.ReadLine();
                        break;
                    }
                    else {
                        Kisi[Kisi.Length - 1] = null;
                        Array.Resize(ref Kisi,Kisi.Length-1);
                        varYok = 1;
                        Console.WriteLine($"{ad} isnindeki kayıt silindi!!");
                        Console.WriteLine("Devam etmek için bir tuşa basın");
                        Console.ReadLine();
                        break;
                    }
                    
                }

            }

            if (varYok==0) { 
                Console.WriteLine($"{ad} isminde bir kayıt bulunamadı!!");
                Console.WriteLine("Devam etmek için bir tuşa basın");
                Console.ReadLine();
          }
        }


    }
}
