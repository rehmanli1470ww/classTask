using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Xestexana
{
    public class Doctor
    {
        public Doctor(string hekiminAdi, string hekiminSoyadi, int isTecrubesi)
        {
            HekiminAdi = hekiminAdi;
            HekiminSoyadi = hekiminSoyadi;
            IsTecrubesi = isTecrubesi;
        }

        public string HekiminAdi { get; set; }
        public string HekiminSoyadi { get; set; }
        public int IsTecrubesi { get; set; }

    }
}
