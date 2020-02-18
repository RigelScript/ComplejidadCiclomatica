using System;

namespace ComplejidadCiclomaticaC
{
    class Laboratorio
    {
        /// <summary>
        /// Complejidad: 2^3 = 8
        /// </summary>
        /// <param name="grado"></param>
        /// <returns></returns>
        public string GetToxicidad(decimal grado)
        {
            if (grado <= 3.8m)
                return "VERDE";

            if (grado <= 8.25m)
                return "AZUL";
            if (grado <= 15m)
                return "AMARILLO";
            return "ROJO";
        }







        ///// <summary>
        ///// Complejidad ciclomatica: 0
        ///// </summary>
        ///// <param name="ph"></param>
        ///// <param name="nivelPlasm"></param>
        ///// <param name="concentracion"></param>
        ///// <param name="acidez"></param>
        ///// <param name="tipo"></param>
        ///// <param name="composicion"></param>
        ///// <returns></returns>
        //public decimal GetGradoToxicidad(EnumPH ph,EnumNivelPlasma nivelPlasm,EnumConcentracion concentracion,EnumAcidez acidez,EnumTipo tipo,EnumComposicion composicion)
        //{
                                   
        //    decimal toxicidad = (((int)ph + (decimal)nivelPlasm) + ((int)concentracion * (decimal)acidez)) / ((int)tipo + (decimal)composicion);

        //    return  (decimal)Math.Round(toxicidad,2);
        //}







        /// <summary>
        /// Complejidad: 0
        /// </summary>
        /// <param name="elem"></param>
        /// <returns></returns>
        public decimal GetGradoToxicidad(Elemento elem)
        {

            decimal toxicidad = (((int)elem.ph + (decimal)elem.nivelPlasma) + ((int)elem.concentracion * (decimal)elem.acidez)) / ((int)elem.tipo + (decimal)elem.composicion);

            return (decimal)Math.Round(toxicidad, 2);
        }


    }
}
