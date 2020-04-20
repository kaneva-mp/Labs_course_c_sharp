using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palette
{
    public partial class Form1 : Form
    {
        /// <summary>
		/// Всплывающая подсказка с номером цвета
		/// </summary>
        ToolTip toolTip = new ToolTip();
        /// <summary>
		/// Текущий цвет
		/// </summary>
        Color currentColor;

        public Form1()
        {
            InitializeComponent();
            scroll(null, null);
        }

        /// <summary>
		/// Передвижение ползунка
		/// Заполнение прямоугольника новым цветом
		/// Запись номера цвета в буфер обмена
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void scroll(object sender, EventArgs e)
        {
            currentColor = Color.FromArgb(red.Value, green.Value, blue.Value);
            panel.BackColor = currentColor;
            Clipboard.SetText(getHEX());
        }

        /// <summary>
		/// Получение шестнадцатеричного кода цвета
		/// </summary>
		/// <returns> Код цвета </returns>
        private string getHEX()
        {
            return "#" + currentColor.R.ToString("X2")
                    + currentColor.G.ToString("X2")
                    + currentColor.B.ToString("X2");
        }

        /// <summary>
		/// Всплывающая подсказка при наведении на панель
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip.SetToolTip(panel, getHEX());
        }
    }
}
