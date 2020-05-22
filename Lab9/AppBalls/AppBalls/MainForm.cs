using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBalls
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private static int numbThread = 0;
        private static bool isWorked = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (isWorked)
            {
                isWorked = false;
                buttonOK.Text = "Старт";
                return;
            }

            if (!(textBoxSiseSquare.Text.All(Char.IsDigit) && textBoxCountBalls.Text.All(Char.IsDigit)))
            {
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(textBoxSiseSquare.Text) < 150 || Convert.ToInt32(textBoxSiseSquare.Text) > 400)
            {
                MessageBox.Show("Сторона квадрата от 150 до 400", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(textBoxCountBalls.Text) < 1 || Convert.ToInt32(textBoxCountBalls.Text) > 15)
            {
                MessageBox.Show("Шариков от 1 до 15", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isWorked = true;
            buttonOK.Text = "Стоп";
            square.Size = new Size(Convert.ToInt32(textBoxSiseSquare.Text), Convert.ToInt32(textBoxSiseSquare.Text));

            for (int i = 0; i < Convert.ToInt32(textBoxCountBalls.Text); i++)
            {
                Thread thread = new Thread(new ThreadStart(moveBall));
                thread.IsBackground = true;
                thread.Start();

                Thread.Sleep(20);
            }
        }

        public void moveBall()
        {
            int number = numbThread;
            Interlocked.Increment(ref numbThread);

            Ball logicBall = new Ball(square.Height);

            RoundPictureBox physicBall = new RoundPictureBox();
            physicBall.BackColor = logicBall.color;
            physicBall.SizeMode = PictureBoxSizeMode.AutoSize;
            physicBall.Location = new Point(logicBall.X, logicBall.Y);
            physicBall.Size = new Size(30, 30);

            Thread.Sleep(25 * number);

            Invoke(new Action(() => { Controls.Add(physicBall); square.SendToBack(); }));

            while (isWorked)
            {
                try
                {
                    Invoke(new Action(() =>
                    {
                        if (logicBall.LeftMove)
                            physicBall.Left += logicBall.Speed;
                        else
                            physicBall.Left -= logicBall.Speed;

                        if (logicBall.UpMove)
                            physicBall.Top += logicBall.Speed;
                        else
                            physicBall.Top -= logicBall.Speed;

                        if (physicBall.Left <= square.Left)
                        {
                            logicBall.LeftMove = true;
                            logicBall.randomUpMove();
                        }

                        if (physicBall.Right >= square.Right)
                        {
                            logicBall.LeftMove = false;
                            logicBall.randomUpMove();
                        }

                        if (physicBall.Top <= square.Top)
                        {
                            logicBall.UpMove = true;
                            logicBall.randomLeftMove();
                        }

                        if (physicBall.Bottom >= square.Bottom)
                        {
                            logicBall.UpMove = false;
                            logicBall.randomLeftMove();
                        }
                    }));
                }
                catch { }

                Thread.Sleep(40);
            }

            Invoke(new Action(() => physicBall.Hide()));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Height = 2000;
        }
    }
}
