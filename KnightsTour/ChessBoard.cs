using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace KnightsTour
{
    // класс рисования шахматной доски
    class ChessBoard
    {
        int row, column, cellSize; // значние размеров доски и размера шахматной клетки
        Point[,] coordinates; // массив координат клеток
        Color[,] cellColor; // массив цвета клеток
        int[,] field; 

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

        // рисование доски на главной форме
        public void Paint(PaintEventArgs e, int count, int x, int y)
        {
            bool isBlack = false;
            Pen pen = new Pen(Color.Black, 2);
            Brush brush;
            Rectangle rect = new Rectangle();
            Graphics gfx = e.Graphics;
            Color color;

            if (column >= 10)
                cellSize = 40;
            else cellSize = 50;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (isBlack)
                    {
                        color = Color.Silver;
                    }
                    else
                    {
                        color = Color.White;
                    }

                    brush = new SolidBrush(color);
                    rect = new Rectangle(i * cellSize + 1, j * cellSize + 1, cellSize, cellSize);
                    coordinates[i, j] = rect.Location;
                    cellColor[i, j] = color;
                    gfx.DrawRectangle(pen, rect);
                    gfx.FillRectangle(brush, rect);
                    if (field[i, j] != 0)
                        gfx.DrawString(field[i, j].ToString(), new Font("Arial", 10), new SolidBrush(Color.Black),
                            coordinates[i, j]);

                    isBlack = !isBlack;
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
            }
        }

        public void FillField(int count, int x, int y)
        {
            field[x, y] = count;
        }
    }
}
