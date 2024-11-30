using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Property_Ogrenme
{
    public class Musteri
    {
        public int sinav1;
        public int sinav2 { get; set; }

        private int kilo; // değişken,field, alan diye geçiyor

        public int KİLO
        {
            get
            {
                return kilo;
            }

            set
            {
                kilo = value;
            }

        }
    }
}
