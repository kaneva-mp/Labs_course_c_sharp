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
	/// Форма для поиска по типу платежа
	/// </summary>
    public partial class TypeSearch : Form
    {
        public string paymentType;
        public bool isSaved = false;

        /// <summary>
		/// Конструктор
		/// По умолчанию квартплата
		/// </summary>
        public TypeSearch()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(PaymentRecord.paymentsType);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
        }

        /// <summary>
		/// Нажатие на кнопку найти
		/// Сохранение введенного типа платежа
		/// Закрытие формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void search_Click(object sender, EventArgs e)
        {
            isSaved = true;
            paymentType = comboBox1.Text;
            Close();
        }
    }
}
