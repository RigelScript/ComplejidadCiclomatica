using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplejidadCiclomaticaC
{
    [TestClass]
    public class UnitTest2
    {
        //[TestMethod]
        //public void PruebaTodos()
        //{
        //    Laboratorio lab = new Laboratorio();
         
        //    Assert.AreEqual(7.71m,lab.GetGradoToxicidad(EnumPH.PH6, EnumNivelPlasma.N10_20, EnumConcentracion.Alta, EnumAcidez.Basico, EnumTipo.MTP, EnumComposicion.Activo));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH6, EnumNivelPlasma.N20_30, EnumConcentracion.Media, EnumAcidez.Alcanino, EnumTipo.Homeopatico, EnumComposicion.Excipiente));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH6, (EnumNivelPlasma)1, EnumConcentracion.Baja,(EnumAcidez)1, (EnumTipo)1, (EnumComposicion)1));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH7, EnumNivelPlasma.N20_30, EnumConcentracion.Baja, EnumAcidez.Basico, EnumTipo.Homeopatico, (EnumComposicion)1));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH7, (EnumNivelPlasma)1, EnumConcentracion.Alta, EnumAcidez.Alcanino, (EnumTipo)1, EnumComposicion.Activo));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH7, EnumNivelPlasma.N10_20, EnumConcentracion.Media, (EnumAcidez)1, EnumTipo.MTP, EnumComposicion.Excipiente));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad((EnumPH)1, (EnumNivelPlasma)1, EnumConcentracion.Media, EnumAcidez.Basico, (EnumTipo)1, EnumComposicion.Excipiente));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad((EnumPH)1, EnumNivelPlasma.N10_20, EnumConcentracion.Baja, EnumAcidez.Alcanino, EnumTipo.MTP, (EnumComposicion)1));
        //    Assert.AreEqual(7.71m, lab.GetGradoToxicidad((EnumPH)1, EnumNivelPlasma.N20_30, EnumConcentracion.Alta, (EnumAcidez)1, EnumTipo.Homeopatico, EnumComposicion.Activo));



        //}

        [TestMethod]
        public void Prueba1()
        {
            Laboratorio lab = new Laboratorio();
            
            Assert.AreEqual(7.71m, lab.GetGradoToxicidad(EnumPH.PH6, EnumNivelPlasma.N10_20, EnumConcentracion.Alta, EnumAcidez.Basico, EnumTipo.MTP, EnumComposicion.Activo));



        }

        [TestMethod]
        public void Prueba2()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(10.29m, lab.GetGradoToxicidad(EnumPH.PH6, EnumNivelPlasma.N20_30, EnumConcentracion.Media, EnumAcidez.Alcanino, EnumTipo.Homeopatico, EnumComposicion.Excipiente));
           
        }


        [TestMethod]
        public void Prueba3()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(8.5m, lab.GetGradoToxicidad(EnumPH.PH6, (EnumNivelPlasma)1, EnumConcentracion.Baja, (EnumAcidez)1, (EnumTipo)1, (EnumComposicion)1));
           
        }

        [TestMethod]
        public void Prueba4()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(8.25m, lab.GetGradoToxicidad(EnumPH.PH7, EnumNivelPlasma.N20_30, EnumConcentracion.Baja, EnumAcidez.Basico, EnumTipo.Homeopatico, (EnumComposicion)1));
            
        }

        [TestMethod]
        public void Prueba5()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(29.33m, lab.GetGradoToxicidad(EnumPH.PH7, (EnumNivelPlasma)1, EnumConcentracion.Alta, EnumAcidez.Alcanino, (EnumTipo)1, EnumComposicion.Activo));
            
        }

        [TestMethod]
        public void Prueba6()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(3.33m, lab.GetGradoToxicidad(EnumPH.PH7, EnumNivelPlasma.N10_20, EnumConcentracion.Media, (EnumAcidez)1, EnumTipo.MTP, EnumComposicion.Excipiente));
                      
        }

        [TestMethod]
        public void Prueba7()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(6.4m, lab.GetGradoToxicidad((EnumPH)1, (EnumNivelPlasma)1, EnumConcentracion.Media, EnumAcidez.Basico, (EnumTipo)1, EnumComposicion.Excipiente));
        }


        [TestMethod]
        public void Prueba8()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(8.17m, lab.GetGradoToxicidad((EnumPH)1, EnumNivelPlasma.N10_20, EnumConcentracion.Baja, EnumAcidez.Alcanino, EnumTipo.MTP, (EnumComposicion)1));
         
        }

        [TestMethod]
        public void Prueba9()
        {
            Laboratorio lab = new Laboratorio();

            Assert.AreEqual(5.40m, lab.GetGradoToxicidad((EnumPH)1, EnumNivelPlasma.N20_30, EnumConcentracion.Alta, (EnumAcidez)1, EnumTipo.Homeopatico, EnumComposicion.Activo));



        }


    }
}
