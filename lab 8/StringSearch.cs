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
	/// ФОрма поиска по строке (квартира, дом, владелец)
	/// </summary>
    public partial class StringSearch : Form
    {
        /// <summary>
		/// Перечисление типов поиска
		/// </summary>
        public enum SearchType
        {
            HouseNumber, ApartNumber, Lastname
        }

        private SearchType searchType;
        public string searchString;
        public bool isSaved = false;

        /// <summary>
		/// Конструктор
		/// </summary>
        public StringSearch()
        {
            InitializeComponent();
        }

        /// <summary>
		/// Конфигурация формы
		/// Изменение надписи 
		/// </summary>
		/// <param name="type"></param>
        public void configure(SearchType type)
        {
            searchType = type;
            label1.Text = "Поиск по ";

            switch (type)
            {
                case SearchType.HouseNumber:
                    label1.Text += "номеру дома";
                    break;
                case SearchType.ApartNumber:
                    label1.Text += "номеру квартиры";
                    break;
                case SearchType.Lastname:
                    label1.Text += "фамилии владельца";
                    break;
            }
        }

        /// <summary>
		/// Нажатие на кнопку поиск
		/// Сохранение введенных данных
		/// Закрытие формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) 
                && textBox1.Text.All(element => searchType == SearchType.Lastname ? Char.IsLetter(element) 
                                                                                  : Char.IsDigit(element)))
            {
                isSaved = true;
                searchString = textBox1.Text;
                Close();
            }
        }
    }
}
