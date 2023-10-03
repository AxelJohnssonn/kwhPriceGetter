namespace PriceApp
{
    public partial class Form1 : Form
    {
        private Curl curl;
        public Form1()
        {
            InitializeComponent();
            curl = new Curl();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            curl.getPrice();


            foreach (String s in curl.getOutput())
            {
                textBox1.AppendText(s);
            }
        }
    }
}