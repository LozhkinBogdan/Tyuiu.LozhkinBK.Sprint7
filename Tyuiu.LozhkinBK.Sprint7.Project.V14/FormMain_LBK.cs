using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Services;

namespace Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms
{
    public partial class FormMain_LBK : Form
    {
        // Список маршрутов — будет хранить все данные
        private List<Transport_LBK> transportList = new List<Transport_LBK>();

        // Сервис для работы с CSV
        private CsvService_LBK csvService = new CsvService_LBK();

        // Сервис для работы с транспортом (поиск/фильтр/сортировка)
        private TransportService_LBK transportService = new TransportService_LBK();

        // Сервис для статистики
        private StatisticsService_LBK statisticsService = new StatisticsService_LBK();

        public FormMain_LBK()
        {
            InitializeComponent();
        }

        private void buttonLoadCsv_LBK_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                transportList = csvService.LoadFromCsv(openFileDialog.FileName);
                dataGridViewTransport_LBK.DataSource = null;
                dataGridViewTransport_LBK.DataSource = transportList;
            }
        }

        private void buttonSaveCsv_LBK_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                csvService.SaveToCsv(saveFileDialog.FileName, transportList);
                MessageBox.Show("File saved successfully");
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewTransport_LBK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_LBK_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_LBK.Text.ToLower();

            // Если строка пустая → показать всё
            if (string.IsNullOrWhiteSpace(searchText))
            {
                dataGridViewTransport_LBK.DataSource = null;
                dataGridViewTransport_LBK.DataSource = transportList;
                return;
            }

            // Пытаемся распарсить число
            int routeNumber;
            bool isNumber = int.TryParse(searchText, out routeNumber);

            var filtered = transportList.Where(t =>
                (isNumber && t.RouteNumber == routeNumber) || // если число
                t.TransportType.ToLower().Contains(searchText) ||
                t.StartStop.ToLower().Contains(searchText) ||
                t.EndStop.ToLower().Contains(searchText) ||
                t.Note.ToLower().Contains(searchText)
            ).ToList();

            dataGridViewTransport_LBK.DataSource = null;
            dataGridViewTransport_LBK.DataSource = filtered;
        }

        private void comboBoxTransportType_LBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTransportType = comboBoxTransportType_LBK.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTransportType) || selectedTransportType == "Все типы")
            {
                // Если не выбран тип, показываем все маршруты
                dataGridViewTransport_LBK.DataSource = transportList;
            }
            else
            {
                // Фильтруем по типу транспорта
                var filteredRoutes = transportService.FilterByTransportType(transportList, selectedTransportType);

                // Обновляем DataGridView
                dataGridViewTransport_LBK.DataSource = null;
                dataGridViewTransport_LBK.DataSource = filteredRoutes;
            }
        }
        private void FormMain_LBK_Load(object sender, EventArgs e)
        {
            // Добавляем типы транспорта в ComboBox
            comboBoxTransportType_LBK.Items.Add("Все типы");
            comboBoxTransportType_LBK.Items.Add("Автобус");
            comboBoxTransportType_LBK.Items.Add("Трамвай");
            comboBoxTransportType_LBK.Items.Add("Троллейбус");

            // Устанавливаем тип по умолчанию
            comboBoxTransportType_LBK.SelectedItem = "Все типы";
        }
        private void buttonAddTransport_LBK_Click(object sender, EventArgs e)
        {
            FormAddEditTransport_LBK form = new FormAddEditTransport_LBK();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Добавляем новый маршрут в список
                transportList.Add(form.transport);

                // Обновляем отображение
                dataGridViewTransport_LBK.DataSource = null;
                dataGridViewTransport_LBK.DataSource = transportList;
            }
        }

        private void buttonDeleteTransport_LBK_Click(object sender, EventArgs e)
        {
            // Получаем индекс выбранной строки в DataGridView
            var selectedRow = dataGridViewTransport_LBK.SelectedRows;
            if (selectedRow.Count > 0)
            {
                // Получаем объект Transport из выбранной строки
                var transportToDelete = selectedRow[0].DataBoundItem as Transport_LBK;
                if (transportToDelete != null)
                {
                    // Удаляем запись из списка
                    transportList.Remove(transportToDelete);

                    // Обновляем таблицу
                    dataGridViewTransport_LBK.DataSource = null;
                    dataGridViewTransport_LBK.DataSource = transportList;
                }
            }
            else
            {
                MessageBox.Show("Выберите маршрут для удаления");
            }
        }

        private void buttonEditTransport_LBK_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewTransport_LBK.SelectedRows;
            if (selectedRow.Count > 0)
            {
                var transportToEdit = selectedRow[0].DataBoundItem as Transport_LBK;
                if (transportToEdit != null)
                {
                    FormAddEditTransport_LBK form = new FormAddEditTransport_LBK(transportToEdit);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Обновляем отображение после редактирования
                        dataGridViewTransport_LBK.DataSource = null;
                        dataGridViewTransport_LBK.DataSource = transportList;
                    }
                }
            }
        }

        private void buttonAddTransport_LBK_Click_1(object sender, EventArgs e)
        {
            FormAddEditTransport_LBK form = new FormAddEditTransport_LBK();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Добавляем новый маршрут в список
                transportList.Add(form.transport);

                // Обновляем отображение
                dataGridViewTransport_LBK.DataSource = null;
                dataGridViewTransport_LBK.DataSource = transportList;
            }
        }

        private void buttonSearch_LBK_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearch_LBK.Text.ToLower(); // Приводим введённый текст к нижнему регистру для нечувствительного поиска
            var filteredList = transportList.Where(t =>
                t.RouteNumber.ToString().Contains(searchTerm) ||
                t.TransportType.ToLower().Contains(searchTerm) ||
                t.StartStop.ToLower().Contains(searchTerm) ||
                t.EndStop.ToLower().Contains(searchTerm) ||
                t.Note.ToLower().Contains(searchTerm)
            ).ToList();

            // Обновляем DataGridView с отфильтрованными данными
            dataGridViewTransport_LBK.DataSource = null;
            dataGridViewTransport_LBK.DataSource = filteredList;
        }

        private void buttonResetFilter_LBK_Click(object sender, EventArgs e)
        {
            // Обновляем DataGridView с полным списком данных
            dataGridViewTransport_LBK.DataSource = null;
            dataGridViewTransport_LBK.DataSource = transportList;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonSortByTravelTime_LBK_Click(object sender, EventArgs e)
        {
            var sortedList = transportList.OrderBy(t => t.TravelTime).ToList(); // Сортируем по возрастанию времени в пути

            // Обновляем DataGridView с отсортированными данными
            dataGridViewTransport_LBK.DataSource = null;
            dataGridViewTransport_LBK.DataSource = sortedList;
        }

        private void buttonShowStatistics_LBK_Click(object sender, EventArgs e)
        {
            // Создаем форму статистики
            FormStatistics_LBK statisticsForm = new FormStatistics_LBK();

            // Обновляем статистику на форме
            statisticsForm.UpdateStatistics(transportList); // передаем весь список или отфильтрованный список

            // Показываем форму
            statisticsForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_LBK_Click(object sender, EventArgs e)
        {
            FormAbout_LBK form = new FormAbout_LBK();
            form.ShowDialog();
        }

        private void userGuideToolStripMenuItem_LBK_Click(object sender, EventArgs e)
        {
            FormGuide_LBK form = new FormGuide_LBK();
            form.ShowDialog();
        }
    }
}
