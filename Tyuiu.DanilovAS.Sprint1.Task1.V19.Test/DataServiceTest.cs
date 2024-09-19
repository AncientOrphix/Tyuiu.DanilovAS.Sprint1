using Tyuiu.DanilovAS.Sprint1.Task1.V19.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task1.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 6;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.5, res);
        }
    }
}