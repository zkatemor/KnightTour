using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KnightsTour
{
    class ChessBoard
    {
        int row, column, cellSize;
        Point[,] coordinates; // массив координат ячеек
        Color[,] cellColor;
        int[,] field;

        public ChessBoard()
        {
            row = 8;
            column = 8;
            coordinates = new Point[row, column];
            field = new int[row, column];
        }

        public ChessBoard(int _row, int _column)
        {
            row = _row;
            column = _column;
            coordinates = new Point[row, column];
            cellColor = new Color[row, column];
            field = new int[row, column];
        }

        public int GetCellSize
        {
            get
            {
                return cellSize;
            }
        }

        public Point[,] GetCoordinates
        {
            get
            {
                return coordinates;
            }
        }

        public Color[,] GetColors
        {
            get
            {
                return cellColor;
            }
        }

        public void Paint(PaintEventArgs e, int count, int x, int y)
        {
            bool isBlack = false;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush;
            Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;

            if (column >= 10)
                cellSize = 40;
            else cellSize = 50;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    if (isBlack)
                    {
                        brush = new SolidBrush(Color.Silver);
                        rect = new Rectangle(i * cellSize - cellSize + 1, j * cellSize - cellSize + 1, cellSize, cellSize);
                        coordinates[i - 1, j - 1] = rect.Location;
                        cellColor[i - 1, j - 1] = Color.Silver;
                        gfx.DrawRectangle(pen, rect);
                        gfx.FillRectangle(brush, rect);
                        if (field[i - 1, j - 1] != 0)
                            gfx.DrawString(field[i - 1, j - 1].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black),
                                coordinates[i - 1, j - 1]);
                        isBlack = false;
                    }
                    else
                    {
                        brush = new SolidBrush(Color.White);
                        rect = new Rectangle(i * cellSize - cellSize + 1, j * cellSize - cellSize + 1, cellSize, cellSize);
                        coordinates[i - 1, j - 1] = rect.Location;
                        cellColor[i - 1, j - 1] = Color.White;
                        gfx.DrawRectangle(pen, rect);
                        gfx.FillRectangle(brush, rect);
                        if (field[i - 1, j - 1] != 0)
                            gfx.DrawString(field[i - 1, j - 1].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black),
                                coordinates[i - 1, j - 1]);
                        isBlack = true;
                    }
                }
                if (column % 2 == 0)
                    isBlack = !isBlack;
            }
            if (count != 0)
            {
                if (field[x, y] == 0)
                {
                    field[x, y] = count;
                }
                gfx.DrawString(field[x, y].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black), coordinates[x, y]);
                // field[x, y] = count;
            }
        }

        public void FillField(int count, int x, int y)
        {
            field[x, y] = count;
        }

    }
}
