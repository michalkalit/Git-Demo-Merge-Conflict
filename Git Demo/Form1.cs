namespace Git_Demo
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object? sender, EventArgs e)
        {
            clickCount++;
            this.countLabel.Text = $"Count: {clickCount}";
        }
    }
}
