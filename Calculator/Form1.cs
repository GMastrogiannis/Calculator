namespace Calculator
{
    public partial class Form1 : Form
    {
        int firstValue;
        int secondValue;
        List<Person> persons = new List<Person>();



        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text += "1";

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            label1.Text += "5";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            label1.Text += "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            label1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            label1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            label1.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("+"))
            {
                String secondV = label1.Text.Split("+")[1];
                secondValue = int.Parse(secondV);
                ShowResult(Add(firstValue, secondValue));
            }
            else if (label1.Text.Contains("-"))
            {

            }
            else if (label1.Text.Contains("*"))
            {

            }
            else if (label1.Text.Contains("/"))
            {

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
             firstValue = int.Parse(label1.Text);
            label1.Text += "+";
        }
        private int Add(int first, int second)
        {
            return first + second;
        }
        private void ShowResult(int result)
        {
            label1.Text = result.ToString();
        }
        private void ShowResult(float result)
        {
            label1.Text = result.ToString();
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "" && comboBox4.SelectedIndex != -1)
            {
                persons.Add(new Person(textBox2.Text, textBox1.Text,
                comboBox4.SelectedIndex == 1 ? false : true));
            }
            ShowPersons();
        }
        private void ShowPersons()
        {
            listBox2.Items.Clear(); 
            foreach (Person p in persons)
            {
                listBox2.Items.Add(string.Format("{0}  {1} Gender {2}", p.FirstName,
                    p.LastName, p.isMale ? "Male" : "Female"));
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}