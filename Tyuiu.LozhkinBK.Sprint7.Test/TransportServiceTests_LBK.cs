using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services;

namespace Tyuiu.LozhkinBK.Sprint7.Test
{
    [TestClass]
    public class TransportServiceTests_LBK
    {
        [TestMethod]
        public void SearchByRoute_ReturnsCorrectRoute()
        {
            TransportService_LBK service = new TransportService_LBK();

            List<Transport_LBK> list = new List<Transport_LBK>()
            {
                new Transport_LBK{ TransportType="Автобус", RouteNumber=12, TravelTime=35 },
                new Transport_LBK{ TransportType="Трамвай", RouteNumber=5, TravelTime=25 }
            };

            var result = service.SearchByRoute(list, 12);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(12, result[0].RouteNumber);
        }
    }
}