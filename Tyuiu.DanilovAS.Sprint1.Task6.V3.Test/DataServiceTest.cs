using Tyuiu.DanilovAS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.DanilovAS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckLastLetterWord()
        {
            DataService ds = new DataService();
            string x = "Сегодня прекрасный солнечный день";
            string res = "яййь";
            Assert.AreEqual(res, ds.LastLetterWord(x));
        }
    }
}