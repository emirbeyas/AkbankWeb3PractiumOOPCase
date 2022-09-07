using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum
{
    public class Gise<T>
    {
        double Bakiye = 0;

        public string[] gecenAracHGSNo = new string[] { };
        public static double toplamGunluk = 0;
        public void odeme(T arac)
        {
            float ucret = 0;

            if (arac is Otomobil)
            {
                ucret = 15;
            }else if (arac is Otobus)
            {
                ucret = 45;
            }else if (arac is Minibus)
            {
                ucret = 30;
            }

            Bakiye = Convert.ToDouble(arac.GetType().GetProperty("Bakiye").GetValue(arac, null));

            if (Bakiye >= ucret)
            {
                Bakiye = Bakiye - ucret;
                toplamGunluk += ucret;

                arac.GetType().GetProperty("Bakiye").SetValue(arac, Bakiye, null);
                gecenAracHGSNo = gecenAracHGSNo.Concat(new string[] { arac.GetType().GetProperty("HGSNo").GetValue(arac, null).ToString() }).ToArray();
                Console.WriteLine(arac.GetType().GetProperty("HGSNo").GetValue(arac, null).ToString() + " HGS Nolu Arac " + ucret +  "TL");
            }
            else
            {
                Console.WriteLine("Dusuk Bakiye");
            }

        }

    }
}
