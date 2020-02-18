using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComplejidadCiclomaticaC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestToxicidad379()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("VERDE", lab.GetToxicidad(3.79m));
        }

        [TestMethod]
        public void TestToxicidad380()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("VERDE", lab.GetToxicidad(3.80m));
        }
        [TestMethod]
        public void TestToxicidad381()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AZUL", lab.GetToxicidad(3.81m));
        }
        [TestMethod]
        public void TestToxicidad824()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AZUL", lab.GetToxicidad(8.24m));
        }

        [TestMethod]
        public void TestToxicidad825()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AZUL", lab.GetToxicidad(8.25m));
        }
        [TestMethod]
        public void TestToxicidad826()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AMARILLO", lab.GetToxicidad(8.26m));
        }

        [TestMethod]
        public void TestToxicidad827()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AMARILLO", lab.GetToxicidad(8.27m));
        }

        [TestMethod]
        public void TestToxicidad1499()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AMARILLO", lab.GetToxicidad(14.99m));
        }
        [TestMethod]
        public void TestToxicidad1500()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("AMARILLO", lab.GetToxicidad(15m));
        }
        [TestMethod]
        public void TestToxicidad1501()
        {
            Laboratorio lab = new Laboratorio();
            Assert.AreEqual("ROJO", lab.GetToxicidad(15.01m));
        }
    }
}
