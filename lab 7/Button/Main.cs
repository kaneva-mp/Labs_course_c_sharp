using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Main : Form
    {
        /// <summary>
		/// Возможные направления движения мышки
		/// </summary>
        private enum MouseDirection
        {
            top, bottom, left, right, zero
        }

        /// <summary>
		/// Предыдущее положение мыши
		/// </summary>
        private Point lastMousePosition;
        /// <summary>
		/// Выход мыши за окно
		/// </summary>
        private bool hasLeft = true;
        /// <summary>
		/// Расстояние от курсора до цента кнопки
		/// </summary>
        private double lastDistance;
        /// <summary>
		/// Предыдущий размер окна
		/// </summary>
        private Size lastWindowSize;

        /// <summary>
		/// Расположение центра кнопки
		/// </summary>
        private Point buttonCenter
        {
            get
            {
                return new Point(button.Location.X + button.Width / 2, button.Location.Y + button.Height / 2);
            }
        }

        /// <summary>
		/// Точка входа
		/// </summary>
        public Main()
        {
            InitializeComponent();
            button.Left = (ClientSize.Width - button.Width) / 2;
            button.Top = (ClientSize.Height - button.Height) / 2;
            lastWindowSize = ClientSize;
        }

        /// <summary>
		/// Нажатие на кнопку и вывод диалогового окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            Dialog dialog = new Dialog();
            dialog.ShowDialog();
        }

        /// <summary>
		/// Движение мыши
		/// При приближении к кнопке ближе, чем заданное расстояние, кнопка передвигается
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            double currentDistance = distance(e.Location, buttonCenter);
            double radius = Math.Max(button.Width, button.Height);

            if (currentDistance < lastDistance && currentDistance < radius)
            {
                moveButton(getMouseDirection(e.Location), (int)distance(e.Location, lastMousePosition));
            }

            lastMousePosition = e.Location;
            lastDistance = currentDistance;
        }

        /// <summary>
		/// Передвижение кнопки
		/// </summary>
		/// <param name="direction"> Направление движения мыши </param>
		/// <param name="distance"> Расстояние от курсора до центра кнопки </param>
        private void moveButton(MouseDirection direction, int distance)
        {
            int mouseSpeed = (SystemInformation.MouseSpeed / 10 + 1) * (int)(distance);

            switch (direction)
            {
                case MouseDirection.top:
                    if (button.Top > 0)
                        button.Top -= button.Top - mouseSpeed < 0
                            ? button.Top
                            : mouseSpeed;
                    break;
                case MouseDirection.left:
                    if (button.Location.X > 0)
                        button.Left -= button.Left - mouseSpeed < 0
                            ? button.Left
                            : mouseSpeed;
                    break;
                case MouseDirection.right:
                    if (button.Left + button.Width < ClientSize.Width)
                        button.Left += button.Left + button.Width + mouseSpeed < ClientSize.Width
                            ? mouseSpeed
                            : ClientSize.Width - button.Left - button.Width;
                    break;
                case MouseDirection.bottom:
                    if (button.Top + button.Height < ClientSize.Height)
                        button.Top += button.Top + button.Height + mouseSpeed < ClientSize.Height
                            ? mouseSpeed
                            : ClientSize.Height - button.Top - button.Height;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
		/// Расстояние между двумя точками
		/// </summary>
		/// <param name="first"> Первая точка </param>
		/// <param name="second"> Вторая точка </param>
		/// <returns> Расстояние между точками </returns>
        private double distance(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }

        /// <summary>
		/// Мышка вышла за пределы окна
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Main_MouseLeave(object sender, EventArgs e)
        {
            hasLeft = true;
        }

        /// <summary>
		/// Определение направления движения мыши
		/// </summary>
		/// <param name="currentMousePosition"> Текущая позиция мыши</param>
		/// <returns> Направление движения </returns>
        private MouseDirection getMouseDirection(Point currentMousePosition)
        {
            if (hasLeft)
            {
                hasLeft = false;
                return MouseDirection.zero;
            }

            double diffX = lastMousePosition.X - currentMousePosition.X;
            double diffY = lastMousePosition.Y - currentMousePosition.Y;

            if (Math.Abs(diffX) > Math.Abs(diffY))
            {
                return diffX < 0 ? MouseDirection.right : MouseDirection.left;
            }
            else
            {
                return diffY < 0 ? MouseDirection.bottom : MouseDirection.top;
            }
        }

        /// <summary>
		/// Обработка изменения размера окна (чтобы кнопка всегда была видна)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                return;

            int diffWidth = (ClientSize.Width - lastWindowSize.Width) / 2;
            int diffHeight = (ClientSize.Height - lastWindowSize.Height) / 2;

            if (button.Left + diffWidth < 0)
            {
                button.Left = 0;
            }
            else
            {
                button.Left += diffWidth;
            }

            if (button.Left + button.Width > ClientSize.Width)
            {
                button.Left = ClientSize.Width - button.Width;
            }
            else
            {
                button.Left = button.Left;
            }

            if (button.Top + diffHeight < 0)
            {
                button.Top = 0;
            }
            else
            {
                button.Top += diffHeight;
            }

            if (button.Top + button.Height > ClientSize.Height)
            {
                button.Top = ClientSize.Height - button.Height;
            }
            else
            {
                button.Top = button.Top;
            }

            lastWindowSize = ClientSize;
        }
    }
}
