namespace FirstFormApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int width = 100;
            int height = 26;
            int margin = 6;
            myButton.Text = "�ڵ忡�� ����!";
            myButton.Width = 123;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "���� ���� " + i + "��°";
                button.Width = width;
                button.Height = height;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
