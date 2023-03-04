namespace calculator
{
    public partial class Form1 : Form
    {
        double num1 = 0, num2 = 0;
        double res = 0;
        char operador = ' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            showResult.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            showResult.Text += btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            showResult.Text += btn3.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            showResult.Text += btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            showResult.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            showResult.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            showResult.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            showResult.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            showResult.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            showResult.Text += btn0.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            showResult.Text = null;
            num1 = 0;
            num2 = 0;
            operador = ' ';
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(showResult.Text);
            showResult.Text += btnMais.Text;
            operador = '+';
            showResult.Text = null;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(showResult.Text);
            showResult.Text += btnMenos.Text;
            operador = '-';
            showResult.Text = null;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(showResult.Text);
            showResult.Text += btnPlus.Text;
            operador = '*';
            showResult.Text = null;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(showResult.Text);
            showResult.Text += btnDiv.Text;
            operador = '/';
            showResult.Text = null;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(showResult.Text);

            if (operador == '+')
            {
                res = num1 + num2;
                showResult.Text = res.ToString();
            }
            else if (operador == '-')
            {
                res = num1 - num2;
                showResult.Text = res.ToString();
            }
            else if (operador == '*')
            {
                res = num1 * num2;
                showResult.Text = res.ToString();
            }
            else
            {
                res = num1 / num2;
                showResult.Text = res.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}