using TestTask.Abstract;

namespace TestTask.Figure
{
    public class Triangle : IFigure
    {
        private double x;
        private double y;
        private double z;

        public bool IsRightTriangle;

        public Triangle(double _x, double _y, double _z)
        {

            if (!CheckTriangleExists(_x, _y, _z))
            {
                throw new ArgumentException("Треугольник с такими сторонами невозможен");
            }

            x = _x;
            y = _y;
            z = _z;

            IsRightTriangle = CheckRightTriangle();

        }

        public double GetSquare()
        {
            var perimeter = (x + y + z) / 2;

            return Math.Round(Math.Sqrt(perimeter * (perimeter - x) * (perimeter - y) * (perimeter - z)), 2);
        }

        private bool CheckRightTriangle()
        {
            return Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(z, 2) || Math.Pow(x, 2) + Math.Pow(z, 2) == Math.Pow(y, 2) || Math.Pow(y, 2) + Math.Pow(z, 2) == Math.Pow(x, 2);
        }

        private bool CheckTriangleExists(double x, double y, double z)
        {
            return x + y > z && x + z > y && z + y > x;
        }
    }
}
