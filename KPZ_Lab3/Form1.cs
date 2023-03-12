namespace KPZ_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ��������� ����� 䳿
            int result = 2 + 2;

            // ��������� 䳿
            Logger logger = Logger.Instance;
            logger.Log($"�������� �������� ��������� ����� 2 � 2, ���������: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // ��������� ����� 䳿
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (Exception ex)
            {
                // ��������� �������
                Logger logger = Logger.Instance;
                logger.Log($"������� �������: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ��������� ����� 䳿 � �����������
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            bool isStudent = checkBox1.Checked;
            string message = $"{name} ({age} ����)";
            if (isStudent)
            {
                message += " � ���������";
            }
            else
            {
                message += " �� � ���������";
            }

            // ��������� 䳿 � �����������
            Logger logger = Logger.Instance;
            logger.Log($"�������� ��: {message}");
        }
    }
}