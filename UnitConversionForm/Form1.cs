namespace UnitConversionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int elapsdTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsdTime++;
            label5.Text = elapsdTime + "�� ���";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double inch = 2.54;
            button1.Text = "���� Ŭ���߽��ϴ�.!";
            double i = double.Parse(textBox1.Text);
            double num = i * inch;
            label4.Text = num.ToString("F2") + "cm";
        }
    }
}
