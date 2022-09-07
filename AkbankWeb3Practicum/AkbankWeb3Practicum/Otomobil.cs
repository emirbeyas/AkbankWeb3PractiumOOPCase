using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum
{
    public class Otomobil : Arac
    {

        public List<DateTime> gecisTarihSaat = new List<DateTime>();

        public Otomobil(string HGSNo, string adSoyad, float Bakiye) : base(HGSNo, adSoyad, Bakiye)
        {

        }


    }
}
