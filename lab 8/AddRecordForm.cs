using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    /// <summary>
	/// Форма для добавления новой записи
	/// </summary>
    public partial class AddRecordForm : Form
    {
        public PaymentRecord record;
        public bool isSaved = false;

        /// <summary>
		/// Конструктор
		/// </summary>
        public AddRecordForm()
        {
            InitializeComponent();
            paymentType.Items.AddRange(PaymentRecord.paymentsType);
            paymentType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
		/// Нажатие на кнопку "Сохранить
		/// Создает объект записи на основе введенных данных
		/// Закрытие формы добавления записи
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void save_Click(object sender, EventArgs e)
        {
            PaymentRecord tempRecord = new PaymentRecord(houseNumberBox.Text,
                                                            apartNumberBox.Text,
                                                            lastnameBox.Text,
                                                            paymentType.Text,
                                                            dateTimePicker1.Value.ToString("dd.MM.yyyy"),
                                                            paymentSumBox.Text,
                                                            pennyPercentBox.Text,
                                                            daysLeftBox.Text);
            if (tempRecord.isCorrect())
            {
                record = tempRecord;
                isSaved = true;
                Close();
            }
            else
            {
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
