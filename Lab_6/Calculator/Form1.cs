using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
	/// Класс калькулятор
	/// </summary>
    public partial class Calculator : Form
    {
        /// <summary>
		/// Текущий результат вычислений
		/// </summary>
        private double calcResult = 0;
        /// <summary>
		/// Последний введенный оператор
		/// </summary>
        private string currentOperator;
        /// <summary>
		/// Значение bool - был ли введен оператор
		/// </summary>
        private bool tappedOperator;
        /// <summary>
		/// Было ли введено число до текущего
		/// </summary>
        private bool isSecondNumber;

        /// <summary>
		/// Конструктор
		/// </summary>
        public Calculator()
        {
            InitializeComponent();
            textBox.Text = calcResult.ToString();
        }

        /// <summary>
		/// Нажатие кнопки с числом (или точкой)
		/// </summary>
		/// <param name="sender">Нажатие кнопки</param>
		/// <param name="e"></param>
        private void tappedNumberButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (tappedOperator)
            {
                textBox.Text = "";
                isSecondNumber = true;
                tappedOperator = false;
            }

            if (textBox.Text.Equals("Ошибка") || (textBox.Text.Equals("0") && !button.Text.Equals(".")))
            {
                textBox.Text = "";
            }

            if (!isSecondDot() && button.Text.Equals("."))
            {
                textBox.Text += button.Text;
            }
            else if (!button.Text.Equals("."))
            {
                textBox.Text += button.Text;
            }
        }

        /// <summary>
		/// Нажатие кнопки с оператором
		/// </summary>
		/// <param name="sender">Нажатие кнопки</param>
		/// <param name="e"></param>
        private void tappedOperationButton(object sender, EventArgs e)
        {
            if (isSecondNumber)
            {
                calculate();

                if (!textBox.Text.Equals("Ошибка"))
                {
                    textBox.Text = calcResult.ToString();
                }

                Clipboard.SetData(DataFormats.Text, (Object)textBox.Text);

                tappedOperator = false;
                isSecondNumber = false;
            } 
            else
            {
                if (textBox.Text.Equals("Ошибка"))
                {
                    calcResult = 0;
                }
                else
                {
                    calcResult = Double.Parse(textBox.Text);
                }
                
            }

            Button button = (Button)sender;
            currentOperator = button.Text;

            tappedOperator = true;
        }

        /// <summary>
		/// Нажатие кнопки Clear
		/// </summary>
		/// <param name="sender">Нажатие кнопки</param>
		/// <param name="e"></param>
        private void tappedClearButton(object sender, EventArgs e)
        {
            textBox.Text = "0";
            isSecondNumber = false;
        }

        /// <summary>
		/// Нажатие кнопки равно
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void tappedEqualButton(object sender, EventArgs e)
        {
            calculate();

            if (!textBox.Text.Equals("Ошибка"))
            {
                textBox.Text = calcResult.ToString();
            }

            Clipboard.SetData(DataFormats.Text, (Object)textBox.Text);

            tappedOperator = false;
            isSecondNumber = false;
            currentOperator = "";
        }

        /// <summary>
		/// Ввод символов с клавиатуры
		/// </summary>
		/// <param name="sender">Нажатие клавиши</param>
		/// <param name="e">Агрументы события нажатия на клавишу</param>
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;

            if (isSecondDot() && symbol == 46)
            {
                e.Handled = true;
            }

            if ((textBox.Text.Length == 1 || textBox.Text.Length == 2 && textBox.Text == "-")
                && symbol == 8)
            {
                textBox.Text = "0";

                if (!tappedOperator)
                {
                    calcResult = 0;
                }

                e.Handled = true;
            }
            else if (symbol == 8 && !tappedOperator)
            {
                calcResult = Double.Parse(textBox.Text.Substring(0, textBox.Text.Length - 1));
            }
            else if (symbol == 8 && tappedOperator)
            {
                tappedOperator = false;
                isSecondNumber = true;
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                if (textBox.Text.Equals("0") || tappedOperator)
                {
                    textBox.Text = "";
                }

                if (tappedOperator)
                {
                    tappedOperator = false;
                    isSecondNumber = true;
                }

                if (!isSecondNumber)
                {
                    calcResult = Double.Parse((textBox.Text + symbol));
                }
            }

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && symbol != 8 && symbol != 46)
            {
                e.Handled = true;
            }
        }

        /// <summary>
		/// Проверка, не введено ли две точки в числе
		/// </summary>
		/// <returns></returns>
        private bool isSecondDot()
        {
            return textBox.Text.Contains(".");
        }

        /// <summary>
		/// Непосредственно вычисление результата
		/// </summary>
        private void calculate()
        {
            double secondNumber = Double.Parse(textBox.Text);

            switch (currentOperator)
            {
                case "+":
                    calcResult += secondNumber;
                    break;
                case "-":
                    calcResult -= secondNumber;
                    break;
                case "*":
                    calcResult *= secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        textBox.Text = "Ошибка";
                        calcResult = 0;
                    }
                    else
                    {
                        calcResult /= secondNumber;
                    }
                    break;
            }
        }
    }
}
