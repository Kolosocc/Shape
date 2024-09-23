using System.Drawing;

namespace Shap
{
    public abstract class ShapeFactory
    {
        public abstract Shape CreateCircle(int size);
        public abstract Shape CreateSquare(int size);
        public abstract Shape CreateTriangle(int size);
    }

    public class RedFactory : ShapeFactory
    {
        public override Shape CreateCircle(int size) => new Circle(Brushes.Red, size);
        public override Shape CreateSquare(int size) => new Square(Brushes.Red, size);
        public override Shape CreateTriangle(int size) => new Triangle(Brushes.Red, size);
    }

    public class BlueFactory : ShapeFactory
    {
        public override Shape CreateCircle(int size) => new Circle(Brushes.Blue, size);
        public override Shape CreateSquare(int size) => new Square(Brushes.Blue, size);
        public override Shape CreateTriangle(int size) => new Triangle(Brushes.Blue, size);
    }
}
