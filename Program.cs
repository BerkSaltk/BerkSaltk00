/**************************************************************************** 
                             * SAKARYA ÜNİVERSİTESİ *     
                 * BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ * 
                  * BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ *     
                     * NESNEYE DAYALI PROGRAMLAMA DERSİ  *  
                           * 2019-2020 BAHAR DÖNEMİ *
                           *    ÖDEV NUMARASI..: 1 *   
                         * ÖĞRENCİ ADI..: BERK SALTIK * 
                        * ÖĞRENCİ NUMARASI..:B181200032 *             
                        * DERSİN ALINDIĞI GRUP...: A Grubu
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telefon_Rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            string basharf;
            int secim1 = 0, secim2 = 0, secim3 = 0, secim4 = 0, secim5 = 0;
            string[] berk = { "Ad Soyad: Berk Saltık\nEv: (216) 417 64 92\nCep: 0538 462 10 97\nAdres:Mustafa Kemal Atatürk caddesi/İstanbul" };
            string[] atamer = { "Ad Soyad: Atamer Başmanav\nEv: (212) 002 05 06\nCep: 0538 698 52 14\nAdres:Nazım Hikmet Ran cad. Piraye Sokak/İstanbul" };
            string[] ada = { "Ad Soayd: Ada Şevval Bal \n Ev: (216) 562 98 78 \n Cep: 0533 333 56 54\nAdres:Çiçek Mahallesi Gül sokağı/Sakarya" };
            string[] burak = { "Ad Soyad: Burakhan Gögce\nEv: (212) 888 87 54\nCep: 0597 901 14 22\nAdres:Göztepe/İstanbul" };
            string[] can = { "Ad Soyad: Can Saltık\nEv: (216) 417 64 92 \nCep: 0589 777 24 54\nAdres:Serdivan/Sakarya" };
            string[] cihan = { "Ad Soyad: Cihan Saltık \nEv: YOK\nCep: 0535 659 68 59\nAdres:Beşiktaş/İstanbul" };
            string[] cemre = { "Ad Soyad: Cemre Oğur \nEv: (216) 626 56 98 \n Cep: 0567 888 41 40\nAdres:Tevfik Sağlam Cad./Maltepe" };
            string[] dilruba = { "Ad Soyad: Dilruba Kuru \nEv: (212) 999 88 56\nCep: YOK\nAdres:Hendek/Sakarya" };
            string[] didem = { "Ad Soyad: Didem SEÇKİN\nEv: (212) 444 30 81\nCep: 0598 612 25 42\nAdres:Kaş/Antalya" };
            string[] ergin = { "Ad Soyad: Ergin Güneri \nEv: (212) 888 58 28\nCep: 0569 887 76 69\nAdres:Erikli/Edirne" };
            string[] ertuğrul = { "Ad Soyad: Ertuğtul Sağlam \nEv: (212) YOK\nCep: 0578 245 78 99\nAdres:Kadıköy/İstanbul" };
            Console.WriteLine("                          -- TELEFON REHBERİ --          ");
            Console.WriteLine("-----------\n           |A|\n           |-|\n           |B|\n Telefon   |-|\n           |C|\n Rehberi   |-|\n           |D|\n           |-|\n           |E|");
            Console.WriteLine("------------");
            Console.Write("Numarasını ve adresini öğrenmek istediğiniz kişinin isminin baş harfini giriniz:  ");
            basharf = Console.ReadLine();
            Console.Clear();
            if ((basharf == "A") || (basharf == "a"))
            {
                Console.WriteLine("A Harfiyle başlayan isimler: \n");
                Console.Write("1) Atamer Başmanav\n2)Ada Şevval Bal \n\nNumarasını ve adresini öğrenmek istediğiniz kişiyi seçiniz (1-2): ");
                secim1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            if (secim1 == 1)
            {
                Console.WriteLine(atamer[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim1 == 2)
            {
                Console.WriteLine(ada[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            else if ((basharf == "B") || (basharf == "b"))
            {
                Console.WriteLine("B Harfiyle başlayan isimler: \n");
                Console.Write("1)Berk Saltık\n2)Burakhan Gögce\n\nNumarasını ve adresini öğrenmek istediğiniz kişiyi seçiniz (1-2): ");
                secim2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            if (secim2 == 1)
            {
                Console.WriteLine(berk[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim2 == 2)
            {
                Console.WriteLine(burak[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            else if ((basharf == "C") || (basharf == "c"))
            {
                Console.WriteLine("C Harfiyle başlayan isimler: \n");
                Console.Write("1)Can Saltık\n2)Cihan Saltık\n3)Cemre Oğur\nNumarasını ve adresini öğrenmek istediğiniz kişiyi seçiniz (1-2-3): ");
                secim3 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            if (secim3 == 1)
            {
                Console.WriteLine(can[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim3 == 2)
            {
                Console.WriteLine(cihan[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim3 == 3)
            {
                Console.WriteLine(cemre[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if ((basharf == "D") || (basharf == "d"))
            {
                Console.WriteLine("A Harfiyle başlayan isimler: \n");
                Console.Write("1)Dilruba Kuru \n2)Didem Seçkin \n\nNumarasını ve adresini öğrenmek istediğiniz kişiyi seçiniz (1-2): ");
                secim4 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            if (secim4 == 1)
            {
                Console.WriteLine(dilruba[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim4 == 2)
            {
                Console.WriteLine(didem[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if ((basharf == "E") || (basharf == "e"))
            {
                Console.WriteLine("A Harfiyle başlayan isimler: \n");
                Console.Write("1)Ergin Güneri\n2)Ertuğrul Sağlam \n\nNumarasını ve adresini öğrenmek istediğiniz kişiyi seçiniz (1-2): ");
                secim5 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
            if (secim5 == 1)
            {
                Console.WriteLine(ergin[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            if (secim5 == 2)
            {
                Console.WriteLine(ertuğrul[0]);
                Console.WriteLine("\n\n\n\nÇıkmak için bir tuşa basınız.");
            }
            Console.ReadKey();
        }
    }
}