namespace ünv_ilk_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("mer");
            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label16.Text = textBox4.Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "......";
            label6.Text = "......";
            label7.Text = "......";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            


            listBox1.Items.Add("  ");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label5.Text);
            listBox1.Items.Add(label6.Text);
            listBox1.Items.Add(label7.Text);
            comboBox1.Items.Add(label16.Text);
            checkBox1.Text = "";

            label13.Text = "Kaydeldildi";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
