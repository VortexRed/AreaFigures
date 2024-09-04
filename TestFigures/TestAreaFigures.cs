using AreaFigures;
namespace TestFigures
{
    [TestClass]
    public class TestAreaFigures
    {
        [TestMethod]
        public void RightTriangleTest()
        {
            Figures figures = new Figures();

            //������������� ����������� � ���������(3, 4, 5)
            bool expected  = figures.RightTriangle(3, 4, 5);
            Assert.IsTrue(expected);

            //�� ������������� ����������� � ���������(3, 3, 5)
            expected = figures.RightTriangle(3, 3, 5);
            Assert.IsFalse(expected);
        }
    }
}