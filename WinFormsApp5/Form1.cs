namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Control control = new Control();

        private void button1_Click(object sender, EventArgs e)
        {
			
			if (control.ClickToOp && control.Count == 2)
				return;

			control.Count = 0;
			Button? button = sender as Button;

			if (textBox1.Text.Contains(","))
				if (button?.Text == ",")
					return;

			if (textBox1.Text == "0")
			{
				textBox1.Text = String.Empty;
				if (button?.Text == "0")
				{
					textBox1.Text = "0";
					textBox1.Text = String.Empty;
				}
			}

			if (!control.ClickToOp)
				textBox1.Text += button?.Text;
			else if (control.ClickToOp)
			{
				control.Number1 = double.Parse(textBox1.Text);
				textBox1.Text = String.Empty;
				control.IsChecked = true;
				control.ClickToOp = false;
				textBox1.Text += button?.Text;
			}

		}





        private void button16_Click(object sender, EventArgs e)
        {

			control.Result += " = ";
			control.Number2 = double.Parse(textBox1.Text);
			control.ClickEquals = true;

			switch (control.Operator)
			{
				case "+":
					control.Result += " " + (control.Number1 + control.Number2).ToString();
					break;
				case "*":
					control.Result += " " + (control.Number1 * control.Number2).ToString();
					break;
				case "-":
					control.Result += " " + (control.Number1 - control.Number2).ToString();
					break;
				case "/":
					control.Result += " " + (control.Number1 / control.Number2).ToString();
					break;
			}

			label2.Text = String.Empty;
			label2.Text = control.Result;
			control.Result = String.Empty;
			++control.CountCalc;
		}

        private void button17_Click(object sender, EventArgs e)
        {
			control.ClickToOp = true;
			Button? button = sender as Button;
			control.Operator = button?.Text;
			var count = textBox1.Text.Count();

			if (button?.Text == control.Operator)
				++count;
			if (count > 1)
				return;
		}

        private void button7_Click(object sender, EventArgs e)
        {
			textBox1.Text = String.Empty;
        }

    }
}