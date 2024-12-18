using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace WinFormsApp1
{
    public partial class UpgradeStoreForm : Form
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        public UpgradeStoreForm()
        {
            InitializeComponent();
        }
        private void ImproveButton_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 10)
            {
                GameForm._clickValue++;
                GameForm._score -= 10;
                GameForm._improveButtonUse1 = true;
                ImproveButton.Enabled = false;


            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImprooveAutoButton_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 100)
            {
                GameForm._autoClickValue++;
                GameForm._score -= 100;
                GameForm._improveAutoButtonUse1 = true;
                ImprooveAutoButton1.Enabled = false;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImproveButton2_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 50 && ImproveButton.Enabled == false)
            {
                GameForm._clickValue++;
                GameForm._score -= 50;
                GameForm._improveButtonUse2 = true;
                ImproveButton2.Enabled = false;


            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void UpgradeStoreForm_Load(object sender, EventArgs e)
        {
            if (GameForm._improveButtonUse1)
            {
                ImproveButton.Enabled = false;
            }
            else
            {
                ImproveButton.Enabled = true;
            }
            if (GameForm._improveButtonUse2)
            {
                ImproveButton2.Enabled = false;
            }
            else
            {
                ImproveButton2.Enabled = true;
            }
            if (GameForm._improveButtonUse3)
            {
                ImproveButton3.Enabled = false;
            }
            else
            {
                ImproveButton3.Enabled = true;
            }
            if (GameForm._improveButtonUse4)
            {
                ImproveButton4.Enabled = false;
            }
            else
            {
                ImproveButton4.Enabled = true;
            }
            if (GameForm._improveAutoButtonUse1)
            {
                ImprooveAutoButton1.Enabled = false;
            }
            else
            {
                ImprooveAutoButton1.Enabled = true;
            }
            if (GameForm._improveAutoButtonUse2)
            {
                ImprooveAutoButton2.Enabled = false;
            }
            else
            {
                ImprooveAutoButton2.Enabled = true;
            }
            if (GameForm._improveAutoButtonUse3)
            {
                ImprooveAutoButton3.Enabled = false;
            }
            else
            {
                ImprooveAutoButton3.Enabled = true;
            }
            if (GameForm._improveAutoButtonUse4)
            {
                ImprooveAutoButton4.Enabled = false;
            }
            else
            {
                ImprooveAutoButton4.Enabled = true;
            }

        }

        private void ImproveButton3_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 200 && ImproveButton2.Enabled == false)
            {
                GameForm._clickValue++;
                GameForm._score -= 200;
                GameForm._improveButtonUse3 = true;
                ImproveButton3.Enabled = false;


            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImproveButton4_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 1000 && ImproveButton3.Enabled == false)
            {
                GameForm._clickValue++;
                GameForm._score -= 1000;
                GameForm._improveButtonUse4 = true;
                ImproveButton4.Enabled = false;


            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImprooveAutoButton2_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 500)
            {
                GameForm._autoClickValue++;
                GameForm._score -= 500;
                GameForm._improveAutoButtonUse2 = true;
                ImprooveAutoButton2.Enabled = false;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImprooveAutoButton3_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 1500)
            {
                GameForm._autoClickValue++;
                GameForm._score -= 1500;
                GameForm._improveAutoButtonUse3 = true;
                ImprooveAutoButton3.Enabled = false;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void ImprooveAutoButton4_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 2500)
            {
                GameForm._autoClickValue++;
                GameForm._score -= 2500;
                GameForm._improveAutoButtonUse4 = true;
                ImprooveAutoButton4.Enabled = false;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void X10Button_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 350)
            {
                Timer10Sec.Start();
                GameForm._clickValue *= 10;
                GameForm._score -= 350;
                Timer10Sec.Interval = 10000;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void Timer10Sec_Tick(object sender, EventArgs e)
        {
            GameForm._clickValue /= 10;
            Timer10Sec.Stop();
        }

        private void X100Button_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 5000)
            {
                Timer30Sec.Start();
                GameForm._clickValue *= 100;
                GameForm._score -= 5000;
                Timer30Sec.Interval = 30000;
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмы братишка");
            }
        }

        private void Timer30Sec_Tick(object sender, EventArgs e)
        {
            GameForm._clickValue /= 100;
            Timer30Sec.Stop();
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            if (GameForm._score >= 15)
            {
                GameForm._score -= 15;
                MessageBox.Show("Поздравляем с завершением игры!");
                this.Close();
                EndGameForm endGameForm = new EndGameForm();
                endGameForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("нет денег нет шаурмечной братишка");
            }
        }
    }
}
