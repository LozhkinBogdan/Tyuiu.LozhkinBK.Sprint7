using System;
using System.Windows.Forms;
using Tyuiu.LozhkinBK.Sprint7.Lib.V14.Models;

namespace Tyuiu.LozhkinBK.Sprint7.Project.V14.Forms
{
    public partial class FormAddEditTransport_LBK : Form
    {
        public Transport_LBK transport { get; set; }

        public FormAddEditTransport_LBK(Transport_LBK transport = null)
        {
            InitializeComponent();

            if (transport != null)
            {
                this.transport = transport;
                // Заполняем поля формы данными маршрута
                textBoxRouteNumber_LBK.Text = transport.RouteNumber.ToString();
                textBoxTransportType_LBK.Text = transport.TransportType;
                textBoxTravelTime_LBK.Text = transport.TravelTime.ToString();
                textBoxStartStop_LBK.Text = transport.StartStop;
                textBoxEndStop_LBK.Text = transport.EndStop;
                textBoxStartDate_LBK.Text = transport.StartDate.ToString("dd.MM.yyyy");
                textBoxNote_LBK.Text = transport.Note;
            }
            else
            {
                this.transport = new Transport_LBK(); // Создаем новый объект, если транспорт не передан
            }
        }

        private void buttonSave_LBK_Click(object sender, EventArgs e)
        {
            try
            {
                // Сохраняем данные из текстовых полей в объект transport
                transport.RouteNumber = Convert.ToInt32(textBoxRouteNumber_LBK.Text);
                transport.TransportType = textBoxTransportType_LBK.Text;
                transport.StartStop = textBoxStartStop_LBK.Text;
                transport.EndStop = textBoxEndStop_LBK.Text;

                // Валидация и преобразование времени в пути
                transport.TravelTime = Convert.ToInt32(textBoxTravelTime_LBK.Text);

                // Валидация и преобразование даты
                if (DateTime.TryParse(textBoxStartDate_LBK.Text, out DateTime startDate))
                {
                    transport.StartDate = startDate;
                }
                else
                {
                    MessageBox.Show("Некорректная дата! Используйте формат: dd.MM.yyyy");
                    return;
                }

                transport.Note = textBoxNote_LBK.Text;

                // Закрываем форму и возвращаем результат
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}