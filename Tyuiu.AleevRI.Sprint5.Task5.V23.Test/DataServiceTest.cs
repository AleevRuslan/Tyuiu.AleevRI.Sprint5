using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AleevRI.Sprint5.Task5.V23.Lib;

namespace Tyuiu.AleevRI.Sprint5.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V23.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string strX = @"C:\DataSprint5\InPutDataFileTask5V23.txt";
            double res = ds.LoadFromDataFile(strX);
            double wait = -9;

            Assert.AreEqual(wait, res); 
        }
    }
}
