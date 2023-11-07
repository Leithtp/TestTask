using TestTask.Abstract;

namespace TestTask.Figure
{
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double _radius)
        {
            if (_radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше 0");
            }
            radius = _radius;
        }

        public double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        }

    }
}