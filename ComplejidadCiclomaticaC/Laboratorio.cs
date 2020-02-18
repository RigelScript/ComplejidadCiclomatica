using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejidadCiclomaticaC
{
     class Laboratorio
    {

        public  string  GetToxicidad(decimal grado)
        {
            if(grado<=3.8m)
            return "VERDE";

            if (grado <= 8.25m)
                return "AZUL";
            if (grado <= 15m)
                return "AMARILLO";
            return "ROJO";
        }
    }
}
