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
    public partial class MainForm : Form
    {
        ChessBoard chessBoard;
        WarnsdorfsRule solve;
        Point next;
        int row, column, size, startX, startY, count = 0;
        bool checkStart = true, checkSolve = true;
        Point[,] coordinates;
        Color[,] cellColor;

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopTimerBitton_Click(sender, e);
            SettingsForm setting = new SettingsForm(row, column, timer.Interval);
            setting.ShowDialog();
            checkSolve = true;
            if (setting.CheckChange && count == row * column - 1)
            {
                DialogResult result = MessageBox.Show("Алгоритм завершен! Сбросить решение и применить настройки?",
                    "Информация", MessageBoxButtons.YesNo , MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    сброситьРешениеToolStripMenuItem_Click(sender, e);
            }
            else if ((row != setting.X || column != setting.Y) && setting.CheckChange && count != row * column - 1)
            {
                DialogResult result = MessageBox.Show("Алгоритм не завершен! Сбросить решение и применить настройки?",
                    "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    сброситьРешениеToolStripMenuItem_Click(sender, e);
            }

            if (setting.CheckChange && checkStart)
            {
                row = setting.X;
                column = setting.Y;
                timer.Interval = setting.Intervl;
                chessBoard = new ChessBoard(row, column);
                coordinates = chessBoard.GetCoordinates;
                cellColor = chessBoard.GetColors;
                size = chessBoard.GetCellSize;
                solve = new WarnsdorfsRule(row, column);
                count = 0; checkStart = true;
                pictureBox_Paint(sender, new PaintEventArgs(pictureBox.CreateGraphics(),
                    new Rectangle(pictureBox.Location, pictureBox.Size)));
                StartKnightPosition();
            }
            else if (row == setting.X && column == setting.Y && !checkStart)
            {
                timer.Interval = setting.Intervl;
            }
        }

        private void следующийХодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nextButton_Click(sender, e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timerButton.Checked == false)
                timer.Stop();
            else
                nextButton_Click(sender, e);
        }

        private void timerButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void автоматическийОбходДоскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (автоматическийОбходДоскиToolStripMenuItem.Checked == true)
                timerButton.Checked = true;
            else
                timerButton.Checked = false;

            timerButton_Click(sender, e);
        }

        private void сброситьРешениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = 0;
            checkStart = true;
            checkSolve = true;
            timerButton.Checked = false;
            автоматическийОбходДоскиToolStripMenuItem.Checked = false;
            timer.Stop();
            solve = new WarnsdorfsRule(row, column);
            chessBoard = new ChessBoard(row, column);
            coordinates = chessBoard.GetCoordinates;
            cellColor = chessBoard.GetColors;
            size = chessBoard.GetCellSize;
            solve = new WarnsdorfsRule(row, column);
            pictureBox_Paint(sender, new PaintEventArgs(pictureBox.CreateGraphics(),
                new Rectangle(pictureBox.Location, pictureBox.Size)));
            horsePictureBox.Visible = false;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (timerButton.Checked == true)
                timer.Stop();

            if (horsePictureBox.Visible == false)
            {
                MessageBox.Show("Чтобы начать обход, поставьте коня на стартовую позицию!",
                   "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (count != row * column - 1)
                {
                    count++;
                    next = solve.NextMove(startX, startY, checkStart);
                    if (next.X == startY && next.Y == startX)
                    {
                        MessageBox.Show("Алгоритм завершен! Решение не найдено!",
                            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        count = row * column - 1;
                        checkSolve = false;
                    }
                    else
                    {
                        Rectangle horse = new Rectangle(new Point(coordinates[next.Y, next.X].X + pictureBox.Location.X,
                        coordinates[next.Y, next.X].Y + pictureBox.Location.Y), new Size(size - 2, size - 2));
                        checkStart = false;

                        horsePictureBox.Size = horse.Size;
                        horsePictureBox.Location = horse.Location;
                        horsePictureBox.BringToFront();
                        horsePictureBox.BackColor = cellColor[next.Y, next.X];
                        horsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    timerButton.Checked = false;
                    if (checkSolve)
                        MessageBox.Show("Алгоритм завершен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Алгоритм завершен! Решение не найдено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (timerButton.Checked == true)
                        timer.Stop();
                }
            }

            if (timerButton.Checked == true)
                timer.Start();
        }

        private void stopTimerBitton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerButton.Checked = false;
            автоматическийОбходДоскиToolStripMenuItem.Checked = false;
        }

        private void остановитьАвтоматическийОбходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopTimerBitton_Click(sender, e);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            сброситьРешениеToolStripMenuItem_Click(sender, e);
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            stopTimerBitton_Click(sender, e);

            if (horsePictureBox.Visible == false)
            {
                MessageBox.Show("Чтобы решить задачу, поставьте коня на стартовую позицию!",
                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (count != row * column - 1)
                {
                    while (count != row * column - 1)
                    {
                        count++;
                        chessBoard.FillField(count, startX, startY);
                        next = solve.NextMove(startX, startY, checkStart);
                        if (next.X == startY && next.Y == startX)
                        {
                            checkSolve = false;
                            break;
                        }
                        startX = next.Y; startY = next.X;
                    }

                    checkStart = false;
                    Rectangle horse = new Rectangle(new Point(coordinates[startX, startY].X + pictureBox.Location.X,
                      coordinates[startX, startY].Y + pictureBox.Location.Y), new Size(size - 2, size - 2));
                    horsePictureBox.Size = horse.Size;
                    horsePictureBox.Location = horse.Location;
                    horsePictureBox.BringToFront();
                    horsePictureBox.BackColor = cellColor[startX, startY];
                    horsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    pictureBox_Paint(sender, new PaintEventArgs(pictureBox.CreateGraphics(),
                       new Rectangle(pictureBox.Location, pictureBox.Size)));

                    if (checkSolve)
                        MessageBox.Show("Алгоритм завершен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Алгоритм завершен! Решение не найдено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (checkSolve)
                        MessageBox.Show("Алгоритм завершен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Алгоритм завершен! Решение не найдено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void решитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solveButton_Click(sender, e);
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            настройкиToolStripMenuItem_Click(sender, e);
        }

        private void informationButton_Click(object sender, EventArgs e)
        {
            InformationForm info = new InformationForm();
            info.ShowDialog();
        }

        private void обАлгоритмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            informationButton_Click(sender, e);
        }

        private void режимИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.ShowDialog();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            режимИгрыToolStripMenuItem_Click(sender, e);
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Забабурина Екатерина Андреевна\nФИб-2301-51-00\nВятГУ, 2018 г", "Об авторе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MainForm()
        {
            InitializeComponent();
            row = 8; column = 8;
            startX = 0; startY = 0;
            chessBoard = new ChessBoard(row, column);
            coordinates = chessBoard.GetCoordinates;
            cellColor = chessBoard.GetColors;
            size = chessBoard.GetCellSize;
            solve = new WarnsdorfsRule(row, column);
            horsePictureBox.Visible = false;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            horsePictureBox.Visible = true;
            if (checkStart == true)
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Rectangle check = new Rectangle(coordinates[i, j].X, coordinates[i, j].Y, size, size);

                        if (check.Contains(e.X, e.Y))
                        {
                            Rectangle horse = new Rectangle(new Point(coordinates[i, j].X + pictureBox.Location.X,
                            coordinates[i, j].Y + pictureBox.Location.Y), new Size(size - 2, size - 2));
                            startX = i; startY = j;
                            horsePictureBox.Size = horse.Size;
                            horsePictureBox.Location = horse.Location;
                            horsePictureBox.BringToFront();
                            horsePictureBox.BackColor = cellColor[i, j];
                            horsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }
                }
        }

        void StartKnightPosition()
        {
            startX = 0; startY = 0;
            Rectangle horse = new Rectangle(new Point(coordinates[0, 0].X + pictureBox.Location.X,
            coordinates[0, 0].Y + pictureBox.Location.Y), new Size(size - 2, size - 2));
            horsePictureBox.Size = horse.Size;
            horsePictureBox.Location = horse.Location;
            horsePictureBox.BringToFront();
            horsePictureBox.BackColor = cellColor[0, 0];
            horsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        void KnightPosition()
        {
            Rectangle horse = new Rectangle(new Point(coordinates[startX, startY].X + pictureBox.Location.X,
                            coordinates[startX, startY].Y + pictureBox.Location.Y), new Size(size - 2, size - 2));
            horsePictureBox.Size = horse.Size;
            horsePictureBox.Location = horse.Location;
            horsePictureBox.BringToFront();
            horsePictureBox.BackColor = cellColor[startX, startY];
            horsePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            chessBoard.Paint(e, count, startX, startY);
            size = chessBoard.GetCellSize;

            if (size == 50)
            {
                this.Width = row * size + 18;
                this.Height = column * size + size + 40;
            }
            else
            {
                this.Width = row * size + size - 22;
                this.Height = column * size + size * 2 + 10;
            }

            this.CenterToScreen();

            if (count != 0)
            {
                startX = next.Y; startY = next.X;
            }
        }
    }
}
