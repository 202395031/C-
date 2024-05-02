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
            myButton.Text = "코드에서 변경!";
            myButton.Width = 123;

            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                Controls.Add(button);
                button.Location = new Point(margin, (height + margin) * (i + 1) + margin);
                button.Text = "동적 생성 " + i + "번째";
                button.Width = width;
                button.Height = height;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
