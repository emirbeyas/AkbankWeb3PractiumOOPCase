using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil arac1 = new Otomobil("1008458695", "Emir Beyaz", 1907);
            Otobus arac2 = new Otobus("1002568896", "Christian Bale", 5465);
            Minibus arac3 = new Minibus("1006987454", "Leonardo DiCaprio", 25);
            Otomobil arac4 = new Otomobil("1001548788", "Tom Cruise", 20);
            Otobus arac5 = new Otobus("1005586788", "Angelina Jolie", 300);
            Minibus arac6 = new Minibus("1005787554", "Scarlett Johansson", 14);
            Otomobil arac7 = new Otomobil("1001455789", "Megan Fox", 35);

            Gise<Arac> gise = new Gise<Arac>();
            Yonetim yonetim = new Yonetim();

            gise.odeme(arac1);
            arac1.gecisTarihSaat.Add(DateTime.Now);
            gise.odeme(arac2);
            arac2.gecisTarihSaat.Add(DateTime.Now.AddDays(1));
            gise.odeme(arac3);
            arac3.gecisTarihSaat.Add(DateTime.Now.AddDays(2));
            gise.odeme(arac4);
            arac4.gecisTarihSaat.Add(DateTime.Now.AddDays(5));
            gise.odeme(arac5);
            arac5.gecisTarihSaat.Add(DateTime.Now.AddDays(4));
            gise.odeme(arac6);
            arac6.gecisTarihSaat.Add(DateTime.Now.AddDays(3));
            gise.odeme(arac7);
            arac7.gecisTarihSaat.Add(DateTime.Now.AddDays(8));
            gise.odeme(arac1);
            arac1.gecisTarihSaat.Add(DateTime.Now.AddDays(2));
            gise.odeme(arac2);
            arac2.gecisTarihSaat.Add(DateTime.Now.AddDays(2));
            gise.odeme(arac3);
            arac3.gecisTarihSaat.Add(DateTime.Now.AddDays(4));
            gise.odeme(arac4);
            arac4.gecisTarihSaat.Add(DateTime.Now.AddDays(7));

            yonetim.GunlukToplam();






        }
    }



}





