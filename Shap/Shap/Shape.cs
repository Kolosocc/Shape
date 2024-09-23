using System.Drawing;

namespace Shap
{
    public abstract class Shape
    {
        public int Size { get; set; }

        protected Shape(int size)
        {
            Size = size;
        }

        public abstract void Draw(Graphics g, int x, int y);
    }

    public class Circle : Shape
    {
        private Brush _brush;

        public Circle(Brush brush, int size) : base(size)
        {
            _brush = brush;
        }

        public override void Draw(Graphics g, int x, int y)
        {
            g.FillEllipse(_brush, x, y, Size, Size);
        }
    }

    public class Square : Shape
    {
        private Brush _brush;

        public Square(Brush brush, int size) : base(size)
        {
            _brush = brush;
        }

        public override void Draw(Graphics g, int x, int y)
        {
            g.FillRectangle(_brush, x, y, Size, Size);
        }
    }

    public class Triangle : Shape
    {
        private Brush _brush;

        public Triangle(Brush brush, int size) : base(size)
        {
            _brush = brush;
        }

        public override void Draw(Graphics g, int x, int y)
        {
            Point[] points =
            {
                new Point(x + Size / 2, y),
                new Point(x, y + Size),
                new Point(x + Size, y + Size)
            };
            g.FillPolygon(_brush, points);
        }
    }
}
