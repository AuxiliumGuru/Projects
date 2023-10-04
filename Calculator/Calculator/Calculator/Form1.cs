namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dotCount;
        bool oper_pressed;
        string operation;
        double val;

        private void button_click(object sender, EventArgs e)
        {
            if (inputBox.Text == "0" || (oper_pressed))
            {
                inputBox.Clear();
                dotCount = 0;
            }

            oper_pressed = false;
            Button b = (Button)sender;
            if (b.Text == "." && dotCount < 1)
            {
                dotCount++;
                inputBox.Text = inputBox.Text + b.Text;
            }

            if (b.Text != ".")
            {
                inputBox.Text = inputBox.Text + b.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            val = Double.Parse(inputBox.Text);
            oper_pressed = true;
            equation.Text = val + " " + operation;
        }

        private void equal_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch (operation)
            {
                case "+":
                    inputBox.Text = (val + Double.Parse(inputBox.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text = (val - Double.Parse(inputBox.Text)).ToString();
                    break;
                case "*":
                    inputBox.Text = (val * Double.Parse(inputBox.Text)).ToString();
                    break;
                case "/":
                    inputBox.Text = (val / Double.Parse(inputBox.Text)).ToString();
                    break;
            }


            if (String.IsNullOrEmpty(inputBox.Text))
            {
                MessageBox.Show("Missing inputs!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double ans = double.Parse(inputBox.Text);
                if (ans == (double)ans)
                {
                    dotCount = 1;
                }

                else
                {
                    dotCount = 0;
                }
            }

        }

        private void clearABtn_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            val = 0;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Substring(0, inputBox.Text.Length - 1);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}