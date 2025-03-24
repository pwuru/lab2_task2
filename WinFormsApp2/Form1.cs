namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textSentence.Text = Properties.Settings.Default.sentence;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence;

            sentence = this.textSentence.Text;

            Properties.Settings.Default.sentence = sentence;
            Properties.Settings.Default.Save();

            var counts = Logic.CountLetters(sentence);

            if (counts == null)
            {
                MessageBox.Show("Введена пустая строка.");
            }
            else if (counts.Count == 0)
            {
                MessageBox.Show("Нет подряд идущих букв.");
            }
            else
            {
                string res = "";
                foreach (var result in counts)
                {
                    res += result;
                    res += "\n";
                }
                MessageBox.Show(res);
            }

        }
    }

    public class Logic
    {
        public static List<string> CountLetters(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null; // Возвращаем null для пустой строки
            }

            str = str.ToLower();
            str = str.Replace(" ", ""); // Убираем все пробелы из строки
            var results = new List<string>();
            int groupSize = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1]) // Сравниваем текущий символ с предыдущим
                {
                    groupSize++;
                }
                else
                {
                    if (groupSize > 1)
                    {
                        results.Add($"Количество подряд идущих букв '{str[i - 1]}': {groupSize}");
                    }
                    groupSize = 1; // Сбрасываем счетчик для новой группы
                }
            }

            // Обрабатываем последнюю группу
            if (groupSize > 1)
            {
                results.Add($"Количество подряд идущих букв '{str[str.Length - 1]}': {groupSize}");
            }

            return results;
        }
    }

}
