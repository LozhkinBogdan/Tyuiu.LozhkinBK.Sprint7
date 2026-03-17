using System;
using System.Collections.Generic;
using System.Linq;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;

namespace Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services
{
    public class TransportService_LBK
    {
        // Поиск по номеру маршрута
        public List<Transport_LBK> SearchByRoute(List<Transport_LBK> list, int routeNumber)
        {
            return list.Where(t => t.RouteNumber == routeNumber).ToList();
        }

        // Фильтр по типу транспорта
        public List<Transport_LBK> FilterByTransportType(List<Transport_LBK> list, string transportType)
        {
            return list.Where(t => t.TransportType.ToLower() == transportType.ToLower()).ToList();
        }

        // Сортировка по времени в пути
        public List<Transport_LBK> SortByTravelTime(List<Transport_LBK> list)
        {
            return list.OrderBy(t => t.TravelTime).ToList();
        }

        // Сортировка по номеру маршрута
        public List<Transport_LBK> SortByRouteNumber(List<Transport_LBK> list)
        {
            return list.OrderBy(t => t.RouteNumber).ToList();
        }
    }
}