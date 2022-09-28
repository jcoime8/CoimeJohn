using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Definitivo
{
    public class CLS_OMB
    {
        private double N1, N2;
        public double N11 { get => N1; set => N1 = value; }
        public double N21 { get => N2; set => N2 = value; }

        public double suma()
        {
            return N11 + N21;
        }
        public double resta()
        {
            return N11 - N21;
        }
        public double multiplicar()
        {
            return N11 * N21;
        }
        public double dividir()
        {
            return N11 / N21;
        }
    }
}
