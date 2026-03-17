using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services;

namespace Tyuiu.LozhkinBK.Sprint7.Test
{
    [TestClass]
    public class StatisticsServiceTests_LBK
    {
        [TestMethod]
        public void AverageTravelTime_ReturnsCorrectValue()
        {
            StatisticsService_LBK service = new StatisticsService_LBK();

            List<Transport_LBK> list = new List<Transport_LBK>()
            {
                new Transport_LBK{ TravelTime=30 },
                new Transport_LBK{ TravelTime=40 }
            };

            double result = service.AverageTravelTime(list);

            Assert.AreEqual(35, result);
        }
    }
}