using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.AleevRI.Sprint5.Task3.V26.Lib;

namespace Tyuiu.AleevRI.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = $@"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint5\Tyuiu.AleevRI.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
