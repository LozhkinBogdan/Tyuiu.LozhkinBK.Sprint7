using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services;

namespace Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms
{
    public partial class FormStatistics_LBK : Form
    {
        private StatisticsService_LBK statisticsService; // Экземпляр StatisticsService_LBK

        public FormStatistics_LBK()
        {
            InitializeComponent();
            statisticsService = new StatisticsService_LBK(); // Инициализация сервиса
        }

        public void UpdateStatistics(List<Transport_LBK> transportList)
        {
            // Получаем статистику из StatisticsService_LBK
            int totalRoutes = statisticsService.CountRoutes(transportList);
            double averageTravelTime = statisticsService.AverageTravelTime(transportList);
            int minTravelTime = statisticsService.MinTravelTime(transportList);
            int maxTravelTime = statisticsService.MaxTravelTime(transportList);

            // Обновляем метки на форме
            labelTotalRoutes_LBK.Text = $"Общее количество маршрутов: {totalRoutes}";
            labelAverageTravelTime_LBK.Text = $"Среднее время в пути: {averageTravelTime:F2} мин";
            labelMinTravelTime_LBK.Text = $"Минимальное время в пути: {minTravelTime} мин";
            labelMaxTravelTime_LBK.Text = $"Максимальное время в пути: {maxTravelTime} мин";

            // Создаем график для отображения среднего времени по типам транспорта
            CreateChart(transportList);
        }

        private void CreateChart(List<Transport_LBK> transportList)
        {
            // Группируем по типу транспорта и рассчитываем среднее время
            var averageTimes = transportList
                .GroupBy(t => t.TransportType)
                .Select(g => new
                {
                    TransportType = g.Key,
                    AverageTime = g.Average(t => t.TravelTime)
                })
                .ToList();

            // Настройка графика
            chartStatistics_LBK.Series.Clear(); // Очищаем предыдущие данные

            // Добавляем серию данных для столбчатой диаграммы
            var series = new Series("Среднее время")
            {
                ChartType = SeriesChartType.Column, // Тип диаграммы — столбчатая
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Int32
            };

            foreach (var item in averageTimes)
            {
                // Добавляем данные для каждого типа транспорта
                series.Points.AddXY(item.TransportType, item.AverageTime);
            }

            // Добавляем серию в график
            chartStatistics_LBK.Series.Add(series);

            // Настройка осей
            chartStatistics_LBK.ChartAreas[0].AxisX.Title = "Тип транспорта";
            chartStatistics_LBK.ChartAreas[0].AxisY.Title = "Среднее время в пути (мин)";
        }
    }
}