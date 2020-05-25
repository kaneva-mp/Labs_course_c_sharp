using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ClientMainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку отправки сообщения
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Событие</param>
        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();

            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Сообщение не должно быть пустым!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            
            OperationResult res = client.SendMessageToServer(textBox.Text);
            
            textBox.Text = "";
            labelRes.Text = res.Message;

            if (res.Result == Result.OK)
            {
                textBox.Text = "";
            }

            timer.Interval = 4000;
            timer.Start();
        }

        /// <summary>
        /// Процедура для остановки таймера
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Событие</param>
        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку отправки файла
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Событие</param>
        private void OnSendFileButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Client client = new Client();
                OperationResult res = client.SendFileToServer(fileDialog.FileName);

                labelRes.Text = res.Message;

                timer.Interval = 4000;
                timer.Start();
            }
        }
    }
}
