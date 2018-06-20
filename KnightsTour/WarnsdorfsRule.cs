using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour
{ 
    class WarnsdorfsRule
    {
        int width, height; 
        int[,] field;
        int count = 0; // счётчик ходов коня

        // структура, описывающая клетку доски
        public struct Vector2 : IComparable, IEquatable<Vector2>
        {
            public int x, y; // координаты клетки
            public int weight // количество возможных ходов конём из этой клетки
            {
                get; set;
            }

            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
                weight = 0;
            }

            public Vector2(int x, int y, int _weight) : this(x, y)
            {
                weight = _weight;
            }

            public int CompareTo(object obj)
            {
                if (obj == null || !(obj is Vector2)) return -1;
                Vector2 temp = (Vector2)obj;
                if (this.weight < temp.weight) return 1;
                if (this.weight == temp.weight) return 0;
                return -1;
            }

            public bool Equals(Vector2 other)
            {
                return this.x == other.x && this.y == other.y;
            }

            public static Vector2 operator +(Vector2 first, Vector2 second)
            {
                return new Vector2(first.x + second.x, first.y + second.y);
            }
        }

        // массив из возможных ходов конём
        public static Vector2[] KnightMove = {
            new Vector2(1, 2),
            new Vector2(1, -2),
            new Vector2(2, 1),
            new Vector2(2, -1),
            new Vector2(-1, 2),
            new Vector2(-1, -2),
            new Vector2(-2, 1),
            new Vector2(-2, -1)
        };

        public WarnsdorfsRule(int _width, int _height)
        {
            width = _width;
            height = _height;
            field = new int[_height, _width];
        }

        private bool IsVectorInField(Vector2 point)  
        {
            return point.x >= 0 && point.x < width && point.y >= 0 && point.y < height;
        }

        // возвращает клетки, на которые может пойти конь
        private List<Vector2> GetNeighbours(Vector2 pos)  
        {
            List<Vector2> result = new List<Vector2>();
            foreach (var m in KnightMove)
            {
                Vector2 temp = pos + m;
                if (IsVectorInField(temp) && !IsCellUsed(temp))
                {
                    temp.weight = GetNeighboursCount(temp);
                    result.Add(temp);
                }
            }
            return result;
        }

        public List<Vector2> GetNeighbours(Vector2 pos, int [,] cells)
        {
            List<Vector2> result = new List<Vector2>();
            foreach (var m in KnightMove)
            {
                Vector2 temp = pos + m;
                if (IsVectorInField(temp) && !IsCellUsed(temp, cells))
                {
                    temp.weight = GetNeighboursCount(temp);
                    result.Add(temp);
                }
            }
            return result;
        }

        // возвращает количество клеток, на которые может пойти конь
        private int GetNeighboursCount(Vector2 pos) 
        {
            int result = 0;
            foreach (var m in KnightMove)
            {
                Vector2 temp = pos + m;
                if (IsVectorInField(temp) && !IsCellUsed(temp))
                    result++;
            }
            return result;
        }

        private bool IsCellUsed(Vector2 pos) 
        {
            return field[pos.y, pos.x] != 0;
        }

        private bool IsCellUsed(Vector2 pos, int [,] cells)
        {
            return cells[pos.y, pos.x] != 0;
        }

        // находит следующий ход коня для обхода доски
        private void NextMove(ref Vector2 temp)
        {
            List<Vector2> neighbours;
            neighbours = GetNeighbours(temp);  
            if (neighbours.Count == 0) return;
            neighbours.Reverse();
            temp = neighbours.OrderBy(a => a.weight).First(); 
        }

        // возвращает следующий ход коня для обхода доски
        public Point NextMove(int startX, int startY, bool first)
        {
            if (first)
                field[startY, startX] = ++count;
            Vector2 temp = new Vector2(startX, startY);
            NextMove(ref temp);
            field[temp.y, temp.x] = ++count;
            Point next = new Point(temp.y, temp.x);
            return next;
        }
        
        public void FillField(int startX, int startY)
        {
            count = 0;
            Vector2 temp = new Vector2(startX, startY);
            field[temp.y, temp.x] = ++count;
            while (count != width * height)
            {
                NextMove(ref temp);
                field[temp.y, temp.x] = ++count;  
            }
        }

        public int[,] Field
        {
            get
            {
                return field;
            }
        }
    }
}
