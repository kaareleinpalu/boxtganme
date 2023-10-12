namespace boxtganme
{
    public partial class Form1 : Form
    {
        private int blueBoxValue;
        private int greenBoxValue;
        private int redBoxValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            int redBoxValue = (int)numericRed.Value;
            greenBoxValue = (int)numericGreen.Value;
            blueBoxValue = (int)numericBlue.Value;
            blueBox.BackColor = Color.FromArgb(greenBoxValue, redBoxValue, blueBoxValue);
        }
    }
}