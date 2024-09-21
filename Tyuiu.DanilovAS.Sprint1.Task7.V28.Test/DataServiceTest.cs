using Tyuiu.DanilovAS.Sprint1.Task7.V28.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            DataService ds = new DataService(); 
            double x = 2;
            double y = 4;
            var res = 16.787;
            Assert.AreEqual(res, ds.Calculate(x, y));

        }
    }
}