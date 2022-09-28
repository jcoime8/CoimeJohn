using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Definitivo
{
    public class CLSlogin
    {
        public string usr = "john";
        public string pws = "pongame10";
        public bool calcular(string usuario, string contraseña)
        {
            bool resultado = false;
            if(usuario == usr &&  contraseña == pws)
            {
                return resultado = true;
            }
            return resultado;
        }
    }
}
