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
        List<Button> cellsList;

        public GameForm()
        {
            InitializeComponent();
            cells = new int[N, N];
            game = new WarnsdorfsRule(N, N);
            knightImage = new Bitmap(KnightsTour.Properties.Resources.knight);
            cellsList = new List<Button>();
            Add();
            ReturnColor();
        }

        private void Add()
        {
            string cellString = "cell";

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    cellString = "cell" + i.ToString() + j.ToString();
                    Button cell = (Button)Controls.Find(cellString, true)[0];
                    cellsList.Add(cell);
                }
            }
        }

        private void ReturnColor()
        {
            int count = 0;
            bool IsBlack = false;

            foreach (var i in cellsList)
            {
                count++;

                i.FlatStyle = FlatStyle.Flat;
                i.FlatAppearance.BorderColor = Color.Black;
                if (!IsBlack)
                    i.BackColor = Color.White;
                else
                    i.BackColor = Color.Silver;

                IsBlack = !IsBlack;

                if (count == 8)
                {
                    IsBlack = !IsBlack;
                    count = 0;
                }
            }
        }

        private void EnabledButtons()
        {
            foreach (var i in cellsList)
            {
                if (i.BackColor != Color.LightGreen)
                    i.Enabled = false;
            }
        }

        private void RemoveButtons()
        {
            foreach (var i in cellsList)
            {
                i.Text = "";
                i.Enabled = true;
            }
        }

        private void RemoveKnight()
        {
            foreach (var i in cellsList)
            {
                if (i.BackgroundImage != null)
                {
                    i.BackgroundImage = null;
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
                  "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void backMoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (count == 1)
                {
                    RemoveSolve();
                }
                else
                {
                    foreach (var i in cellsList)
                    {
                        if (i.Text == count.ToString())
                        {
                            string cellName = i.Name;
                            var cellIndex = cellName.Where(j => Char.IsDigit(j)).ToArray();
                            int x = int.Parse(cellIndex[0].ToString());
                            int y = int.Parse(cellIndex[1].ToString());
                            i.Text = "";
                            count--;
                            cells[y, x] = 0;
                            break;
                        }
                    }

                    foreach (var i in cellsList)
                    {
                        if (i.Text == count.ToString())
                        {
                            RemoveKnight();
                            ReturnColor();
                            i.BackgroundImage = knightImage;
                            i.BackgroundImageLayout = ImageLayout.Stretch;
                            i.Text = count.ToString();

                            string cellName = i.Name;
                            var cellIndex = cellName.Where(j => Char.IsDigit(j)).ToArray();
                            int x = int.Parse(cellIndex[0].ToString());
                            int y = int.Parse(cellIndex[1].ToString());
                            WarnsdorfsRule.Vector2 cell = new WarnsdorfsRule.Vector2(x, y);
                            List<WarnsdorfsRule.Vector2> neighbours = game.GetNeighbours(cell, cells);
                            checkSolve = false;

                            string cellString = "cell";
                            foreach (var n in neighbours)
                            {
                                cellString += n.x.ToString() + n.y.ToString();
                                Button b = (Button)Controls.Find(cellString, true)[0];
                                if (i.Text != "")
                                {
                                    b.BackColor = Color.LightGreen;
                                    b.Enabled = true;
                                }
                                cellString = "cell";
                            }
                            EnabledButtons();
                            break;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void screenButton_Click(object sender, EventArgs e)
        {
            Bitmap screen = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(screen, new Rectangle(Point.Empty, this.Size));

            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                screen.Save(fileName);
                MessageBox.Show("Скрин формы сохранен!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
