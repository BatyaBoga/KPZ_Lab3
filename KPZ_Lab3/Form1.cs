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
            // Здійснення якоїсь дії
            int result = 2 + 2;

            // Логування дії
            Logger logger = Logger.Instance;
            logger.Log($"Здійснено операцію додавання чисел 2 і 2, результат: {result}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Здійснення якоїсь дії
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (Exception ex)
            {
                // Логування помилки
                Logger logger = Logger.Instance;
                logger.Log($"Сталась помилка: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Здійснення якоїсь дії з параметрами
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            bool isStudent = checkBox1.Checked;
            string message = $"{name} ({age} років)";
            if (isStudent)
            {
                message += " є студентом";
            }
            else
            {
                message += " не є студентом";
            }

            // Логування дії з параметрами
            Logger logger = Logger.Instance;
            logger.Log($"Виконано дію: {message}");
        }
    }
}