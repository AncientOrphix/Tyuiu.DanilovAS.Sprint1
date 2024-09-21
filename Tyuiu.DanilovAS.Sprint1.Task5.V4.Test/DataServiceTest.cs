using Tyuiu.DanilovAS.Sprint1.Task5.V4.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSecondsToHours()
        {
            DataService ds = new DataService();
            int time = 13257;
            var res = 3;
            
            Assert.AreEqual(res, ds.SecondsToHours(time));
        }
    }
}