using TestTask.Figure;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Circle_GetSquare_ShouldReturnCorrectResult()
        {
            var circle = new Circle(5);
            var result = circle.GetSquare();

            Assert.Equal(78.54, result);
        }

        [Fact]
        public void Circle_InvalidParameters_ThrowArgumentException()
        {

            var ex = Assert.Throws<ArgumentException>(() => new Circle(-5)); ;

            Assert.Equal("Радиус не может быть меньше 0", ex.Message);
        }


        [Fact]
        public void Triangle_InvalidParameters_ThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(-5, 1, 2));

            Assert.Equal("Треугольник с такими сторонами невозможен", ex.Message);
        }

        [Fact]
        public void Triangle_GetSquare_ShouldReturnCorrectResult()
        {

            var triangle = new Triangle(5, 2, 6);
            var result = triangle.GetSquare();

            Assert.Equal(4.68, result);

        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldReturnCorrectResult()
        {
            var triangle = new Triangle(3, 4, 5);
            var result = triangle.IsRightTriangle;

            Assert.True(result);


        }
    }
}