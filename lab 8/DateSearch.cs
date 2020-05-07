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
	/// Форма для поиска записи по дате
	/// </summary>
    public partial class DateSearch : Form
    {
        public string paymentDate;
        public bool isSaved = false;

        /// <summary>
		/// Конструктор
		/// </summary>
        public DateSearch()
        {
            InitializeComponent();
        }

        /// <summary>
		/// Нажатие на кнопку "найти"
		/// Сохранение введенной даты
		/// Закрытие формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            paymentDate = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            isSaved = true;
            Close();
        }
    }
}
