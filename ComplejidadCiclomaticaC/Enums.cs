using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplejidadCiclomaticaC
{
    public enum EnumPH:int
    {
        PH6=6,
        PH7=7
    }

    public enum EnumNivelPlasma : int
    {
        N10_20=8,
        N20_30=6
    }


    public enum EnumConcentracion : int
    {
        Alta=20,
        Media=15,
        Baja=10
    }

    public enum EnumAcidez : int
    {
      
        Basico=2,
        Alcanino=4
    }

    public enum EnumTipo : int
    {
       MTP=5,
       Homeopatico=3
    }

    public enum EnumComposicion : int
    {
        Activo=2,
        Excipiente=4
    }

}
