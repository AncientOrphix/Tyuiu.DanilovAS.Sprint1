using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DanilovAS.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            double result = Convert.ToDouble(time/3600);
            result = Math.Round(result,0);
            return Convert.ToInt32(result);
        }
    }
}
