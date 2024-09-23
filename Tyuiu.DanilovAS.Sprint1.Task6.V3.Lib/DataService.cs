using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DanilovAS.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Строка для хранения последних букв
            string lastLetters = "";

            // Итерация по каждому слову
            foreach (string word in words)
            {
                // Проверяем, что слово не пустое
                if (word.Length > 0)
                {
                    // Добавляем последнюю букву слова к результату
                    lastLetters += word[word.Length - 1];
                }
            }
            return Convert.ToString(lastLetters);
        }
    }
}
