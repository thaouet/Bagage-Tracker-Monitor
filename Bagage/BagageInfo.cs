using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagage
{
  public  class BagageInfo
    {
        private int numeroVol;
        private string origine;
        private int carrousel;

        public int NumeroVol
        {
            get
            {
                return numeroVol;
            }

        }

        public string Origine
        {
            get
            {
                return origine;
            }

        }

        public int Carrousel
        {
            get
            {
                return carrousel;
            }

        }

        public BagageInfo(int n, string o, int c)
        {
            numeroVol = n;
            origine = o;
            carrousel = c;
        }
    }
}
