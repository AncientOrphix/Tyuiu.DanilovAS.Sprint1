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
            string x = "������� ���������� ��������� ����";
            string res = "����";
            Assert.AreEqual(res, ds.LastLetterWord(x));
        }
    }
}