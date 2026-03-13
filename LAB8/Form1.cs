using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8
{
    public partial class MainForm : Form
    {
        private Timer AnimationTimer;
        private int targetX;
        private const int speed = 10;

        public MainForm()
        {
            this.Size = new Size(600, 300);
            this.Text = "Анімація руху кнопки";

            // Створюємо кнопку
            MovingButton = new Button();
            MovingButton.Text = "Рухай мене";
            MovingButton.Size = new Size(120, 40);
            MovingButton.Location = new Point(10, 100);
            MovingButton.Click += MovingButton_Click;
            this.Controls.Add(MovingButton);

            AnimationTimer = new Timer();
            AnimationTimer.Interval = 40;
            AnimationTimer.Tick += AnimationTimer_Tick;
        }

        private void MovingButton_Click(object sender, EventArgs e)
        {
            if (MovingButton.Left < this.ClientSize.Width / 2)
                targetX = this.ClientSize.Width - MovingButton.Width - 10;
            else
                targetX = 10;

            AnimationTimer.Start();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (MovingButton.Left < targetX)
            {
                MovingButton.Left += speed;
                if (MovingButton.Left >= targetX)
                {
                    MovingButton.Left = targetX;
                    AnimationTimer.Stop();
                }
            }
            else if (MovingButton.Left > targetX)
            {
                MovingButton.Left -= speed;
                if (MovingButton.Left <= targetX)
                {
                    MovingButton.Left = targetX;
                    AnimationTimer.Stop();
                }
            }
        }
    }
}
