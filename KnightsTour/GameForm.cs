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
    public partial class GameForm : Form
    {
        int[,] cells;
        int count = 0;
        int N = 8; bool checkSolve = true;
        WarnsdorfsRule game;
        Bitmap knightImage;

        public GameForm()
        {
            InitializeComponent();
            cells = new int[N, N];
            game = new WarnsdorfsRule(N, N);
            knightImage = new Bitmap(KnightsTour.Properties.Resources.knight);
            ReturnColor();
        }

        private void ReturnColor()
        {
            string cellString = "cell";
            bool IsBlack = false;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cellString = "cell" + i.ToString() + j.ToString();
                    Button check = (Button)Controls.Find(cellString, true)[0];
                    check.FlatStyle = FlatStyle.Flat;
                    check.FlatAppearance.BorderColor = Color.Black;
                    if (!IsBlack)
                        check.BackColor = Color.White;
                    else
                        check.BackColor = Color.Silver;
                    IsBlack = !IsBlack;
                }
                IsBlack = !IsBlack;
            }

        }

        private void EnabledButtons()
        {
            string cellString = "cell";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cellString = "cell" + i.ToString() + j.ToString();
                    Button check = (Button)Controls.Find(cellString, true)[0];
                    if (check.BackColor != Color.LightGreen)
                        check.Enabled = false;
                }
            }
        }

        private void RemoveButtons()
        {
            string cellString = "cell";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cellString = "cell" + i.ToString() + j.ToString();
                    Button check = (Button)Controls.Find(cellString, true)[0];
                    check.Text = "";
                    check.Enabled = true;
                }
            }
        }

        private void RemoveKnight()
        {
            string cellString = "cell";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cellString = "cell" + i.ToString() + j.ToString();
                    Button check = (Button)Controls.Find(cellString, true)[0];
                    if (check.Text != "")
                    {
                        check.BackgroundImage = null;
                    }
                }
            }
        }

        private void RemoveSolve()
        {
            cells = new int[N, N];
            game = new WarnsdorfsRule(N, N); 
            count = 0;
            RemoveKnight();
            ReturnColor();
            RemoveButtons();
        }

        private void cell00_Click(object sender, EventArgs e)
        {
            string cellName = (sender as Button).Name;
            Button cellXY = (Button)Controls.Find(cellName, true)[0];

            var cellIndex = cellName.Where(i => Char.IsDigit(i)).ToArray();
            int x = int.Parse(cellIndex[0].ToString());
            int y = int.Parse(cellIndex[1].ToString());

            RemoveKnight();
            ReturnColor();
            cells[y, x] = ++count;
            cellXY.BackgroundImage = knightImage;
            cellXY.BackgroundImageLayout = ImageLayout.Stretch;
            cellXY.Text = count.ToString();
            string cellString = "cell";
            WarnsdorfsRule.Vector2 cell = new WarnsdorfsRule.Vector2(x, y);
            List<WarnsdorfsRule.Vector2> neighbours = game.GetNeighbours(cell, cells);

            if (neighbours.Count == 0 && count != N * N)
            {
                EnabledButtons(); checkSolve = true;
                DialogResult result = MessageBox.Show("Хотите начать заново?",
                    "Вы проиграли!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RemoveSolve();
                }
            }
            else if (neighbours.Count == 0 && count == N * N)
            { 
                EnabledButtons(); checkSolve = true;
                DialogResult result = MessageBox.Show("Хотите начать заново?",
                   "Вы выиграли!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RemoveSolve();
                }
            }
            else
            {
                checkSolve = false;
                foreach (var i in neighbours)
                {
                    cellString += i.x.ToString() + i.y.ToString();
                    Button b = (Button)Controls.Find(cellString, true)[0];
                    if (cellXY.Text != "")
                    {
                        b.BackColor = Color.LightGreen;
                        b.Enabled = true;
                    }
                    cellString = "cell";
                }
                EnabledButtons();
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!checkSolve)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть игру?",
                  "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
