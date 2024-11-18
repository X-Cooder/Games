namespace cal_cu_la_tor
{
    public partial class Form1 : Form
    {
        public double a, b, result;
        public string operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }



        private void btn4_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            tbScreen.Text += btn.Text;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = double.Parse(tbScreen.Text);
            tbScreen.Text = "";
            operation = btn.Text;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = int.Parse(tbScreen.Text);
            tbScreen.Text = "";
            operation = btn.Text;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = int.Parse(tbScreen.Text);
            tbScreen.Text = "";
            operation = btn.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!tbScreen.Text.Contains("."))
            {
                Button btn = (Button)sender;
                tbScreen.Text += btn.Text;
            }
            else
            {
                MessageBox.Show("Decimal point already entered");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbScreen.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            a = int.Parse(tbScreen.Text);
            tbScreen.Text = "";
            operation = btn.Text;
        }

        private void btnEQ_Click(object sender, EventArgs e)
        {
            if (tbScreen.Text == "0" && operation == "/")
            {
                MessageBox.Show("Cannot divide by zero");
                return;
            }

            b = double.Parse(tbScreen.Text);

            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
            }
            tbScreen.Text = result.ToString();

        }
    }
}