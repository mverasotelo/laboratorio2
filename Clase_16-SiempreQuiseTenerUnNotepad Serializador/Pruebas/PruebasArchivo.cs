using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
using System;
using System.IO;

namespace Pruebas
{
    [TestClass]
    public class PruebasArchivo
    {
        [TestMethod]
        public void ValidarExtensionPuntoTxt_RecibeArchivoConExtensionPuntoTxt_DeberiaDevolverTrue()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.txt");
            PuntoTxt archivo = new PuntoTxt();
            bool expected = true;

            //Act
            bool actual = archivo.ValidarExtension(rutaArchivo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArchivoIncorrectoException))]
        [TestMethod]
        public void ValidarExtensionPuntoTxt_RecibeArchivoConExtensionPuntoXml_DeberiaDevolverTrue()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.xml");
            PuntoTxt archivo = new PuntoTxt();

            //Act
            bool actual = archivo.ValidarExtension(rutaArchivo);
        }

        [TestMethod]
        public void ValidarExtensionPuntoXml_RecibeArchivoConExtensionPuntoXml_DeberiaDevolverTrue()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.xml");
            PuntoXml<string> archivo = new PuntoXml<string>();
            bool expected = true;

            //Act
            bool actual = archivo.ValidarExtension(rutaArchivo);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [ExpectedException(typeof(ArchivoIncorrectoException))]
        [TestMethod]
        public void ValidarExtensionPuntoXml_RecibeArchivoConExtensionPuntoJson_DeberiaDevolverFalse()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.json");
            PuntoXml<string> archivo = new PuntoXml<string>();

            //Act
            archivo.ValidarExtension(rutaArchivo);
        }

        [TestMethod]
        public void ValidarExtensionPuntoJson_RecibeArchivoConExtensionPuntoJson_DeberiaDevolverTrue()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.json");
            PuntoJson<string> archivo = new PuntoJson<string>();
            bool expected = true;

            //Act
            bool actual = archivo.ValidarExtension(rutaArchivo);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(ArchivoIncorrectoException))]
        [TestMethod]
        public void ValidarExtensionPuntoJson_RecibeArchivoConExtensionPuntoTxt_DeberiaDevolverFalse()
        {
            //Arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(ruta, "holamundo.txt");
            PuntoJson<string> archivo = new PuntoJson<string>();

            //Act
            archivo.ValidarExtension(rutaArchivo);
        }

    }
}
