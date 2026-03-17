using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services;

namespace Tyuiu.LozhkinBK.Sprint7.Test
{
    [TestClass]
    public class CsvServiceTests_LBK
    {
        [TestMethod]
        public void SaveAndLoadCsv_WorksCorrectly()
        {
            CsvService_LBK service = new CsvService_LBK();

            string path = "test.csv";

            List<Transport_LBK> list = new List<Transport_LBK>()
            {
                new Transport_LBK{ TransportType="Автобус", RouteNumber=1, TravelTime=20 }
            };

            service.SaveToCsv(path, list);

            var loaded = service.LoadFromCsv(path);

            Assert.AreEqual(1, loaded.Count);
            Assert.AreEqual("Автобус", loaded[0].TransportType);

            File.Delete(path);
        }
    }
}