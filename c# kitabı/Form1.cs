namespace c__kitabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
            label7.Text = textBox2.Text;
            MessageBox.Show("İşlem Tamam");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Hazırlık oe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!listBox1.Items.Contains(textBox4.Text))
                listBox1.Items.Add(textBox4.Text); 
            else
                listBox1.Items.Remove(textBox4.Text);
        }
    }
}
