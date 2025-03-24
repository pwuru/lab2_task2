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
                MessageBox.Show("������� ������ ������.");
            }
            else if (counts.Count == 0)
            {
                MessageBox.Show("��� ������ ������ ����.");
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
                return null; // ���������� null ��� ������ ������
            }

            str = str.ToLower();
            str = str.Replace(" ", ""); // ������� ��� ������� �� ������
            var results = new List<string>();
            int groupSize = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1]) // ���������� ������� ������ � ����������
                {
                    groupSize++;
                }
                else
                {
                    if (groupSize > 1)
                    {
                        results.Add($"���������� ������ ������ ���� '{str[i - 1]}': {groupSize}");
                    }
                    groupSize = 1; // ���������� ������� ��� ����� ������
                }
            }

            // ������������ ��������� ������
            if (groupSize > 1)
            {
                results.Add($"���������� ������ ������ ���� '{str[str.Length - 1]}': {groupSize}");
            }

            return results;
        }
    }

}
