using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;

namespace Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services
{
    public class StatisticsService_LBK
    {
        // Количество маршрутов
        public int CountRoutes(List<Transport_LBK> list)
        {
            return list.Count;
        }

        // Среднее время в пути
        public double AverageTravelTime(List<Transport_LBK> list)
        {
            return list.Count == 0 ? 0 : list.Average(t => t.TravelTime);
        }

        // Минимальное время в пути
        public int MinTravelTime(List<Transport_LBK> list)
        {
            return list.Count == 0 ? 0 : list.Min(t => t.TravelTime);
        }

        // Максимальное время в пути
        public int MaxTravelTime(List<Transport_LBK> list)
        {
            return list.Count == 0 ? 0 : list.Max(t => t.TravelTime);
        }
    }
}