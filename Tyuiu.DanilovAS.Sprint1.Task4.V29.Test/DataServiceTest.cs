using Tyuiu.DanilovAS.Sprint1.Task4.V29.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 4 ;
            double y = 6 ;
            var res = 0.007;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}