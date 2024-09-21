using Tyuiu.DanilovAS.Sprint1.Task3.V15.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDistanceOverTime()
        {
            DataService ds = new DataService();
            var v1 = 4;
            var v2 = 5;
            var S = 2;
            var T = 54;
            var res = 52;
            Assert.AreEqual(res, ds.DistanceOverTime(v1,v2,S,T));
        }
    }
}