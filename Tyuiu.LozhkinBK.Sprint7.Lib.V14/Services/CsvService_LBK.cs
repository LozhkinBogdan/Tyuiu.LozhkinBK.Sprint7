using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;

namespace Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services
{
    public class CsvService_LBK
    {
        public List<Transport_LBK> LoadFromCsv(string path)
        {
            List<Transport_LBK> list = new List<Transport_LBK>();

            var lines = File.ReadAllLines(path);

            for (int i = 1; i < lines.Length; i++)
            {
                var data = lines[i].Split(';');

                Transport_LBK transport = new Transport_LBK
                {
                    TransportType = data[0],
                    RouteNumber = int.Parse(data[1]),
                    StartDate = DateTime.Parse(data[2]),
                    StartStop = data[3],
                    EndStop = data[4],
                    TravelTime = int.Parse(data[5]),
                    Note = data[6]
                };

                list.Add(transport);
            }

            return list;
        }

        public void SaveToCsv(string path, List<Transport_LBK> list)
        {
            List<string> lines = new List<string>();

            lines.Add("TransportType;RouteNumber;StartDate;StartStop;EndStop;TravelTime;Note");

            foreach (var t in list)
            {
                lines.Add($"{t.TransportType};{t.RouteNumber};{t.StartDate};{t.StartStop};{t.EndStop};{t.TravelTime};{t.Note}");
            }

            File.WriteAllLines(path, lines);
        }
    }
}