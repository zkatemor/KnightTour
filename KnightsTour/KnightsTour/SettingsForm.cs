using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightsTour
{
    public partial class SettingsForm : Form
    {
        public int X, Y, Intervl;
        int x, y, interval;
        public bool CheckChange = false;

        public SettingsForm(int X, int Y, int Intervl)
        {
            InitializeComponent();
            x = X; y = Y; interval = Intervl;
            trackBarWidth.Value = X;
            trackBarHeight.Value = Y;
            trackBarInterval.Value = Intervl;
            currentWidth.Text = "Текущая: " + trackBarWidth.Value.ToString();
            currentHeight.Text = "Текущая: " + trackBarHeight.Value.ToString();
            currentInterval.Text = "Текущий: " + stringInterval(trackBarInterval.Value);
        }

        private string stringInterval(int interval)
        {
            if (interval == 1000 || interval == 2000 || interval == 3000)
                return interval.ToString().First().ToString() + " сек";
            else if (interval > 1000)
                return interval.ToString().First().ToString() + " сек " + int.Parse(interval.ToString().Substring(1)) + " мс";
            else return interval.ToString() + " мс";
        }

        private void trackBarInterval_Scroll(object sender, EventArgs e)
        {
            currentInterval.Text = "Текущий: " + stringInterval(trackBarInterval.Value);
        }

        private void trackBarWidth_Scroll(object sender, EventArgs e)
        {
            currentWidth.Text = "Текущая: " + trackBarWidth.Value.ToString();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            CheckChange = true;
            X = trackBarWidth.Value;
            Y = trackBarHeight.Value;
            Intervl = trackBarInterval.Value;
            Close();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckChange)
            {
                X = x;
                Y = y;
                Intervl = interval;
            }
        }

        private void trackBarHeight_Scroll(object sender, EventArgs e)
        {
            currentHeight.Text = "Текущая: " + trackBarHeight.Value.ToString();
        }
    }
}
