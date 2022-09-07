using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbankWeb3Practicum
{
    public class Arac
    {
        public string HGSNo { set; get; }
        public string adSoyad { set; get; }
        public double Bakiye { set; get; }   

        public Arac(string HGSNo, string adSoyad, double Bakiye)
        {
            this.HGSNo = HGSNo;
            this.adSoyad = adSoyad;
            this.Bakiye = Bakiye;
        }

    }
}
