using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Definitivo
{
    public class CLS_SrFigonasi
    {
        public int[] calcularSerie(int limite)
        {
            int[] res = new int[limite];
            if(limite > 2)
            {
                res[0] = 0;
                res[1] = 1;
                for(int i=2; i < limite; i++)
                {
                    res[i] = res[i-1] + res[i-2];
                }
             
            }
            else
            {
                res[0] = 100;
            }
            return res;
        }
    }
}
