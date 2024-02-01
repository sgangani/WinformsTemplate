namespace WinformDemo;

public partial class Form1 : Form
{
    private Label label1, label2, label3;

    private TextBox textBox1, textBox2, textBox3;

    private Button button1, button2, button3, button4;
    public Form1()
    {
        InitializeComponent();
        // this.BackColor = Color.Gray;
    }

    private void Addition(object sender, EventArgs e)
    {
        Calculation('+');
    }
    private void Subtraction(object sender, EventArgs e)
    {
        Calculation('-');
    }
    private void Multiplication(object sender, EventArgs e)
    {
        Calculation('*');
    }
    private void Division(object sender, EventArgs e)
    {
        Calculation('/');
    }

    private void Calculation(char operation)
    {
        if (double.TryParse(textBox1.Text, out double operand1) && double.TryParse(textBox2.Text, out double operand2))
        {
            switch (operation)
            {
                case '+':
                    textBox3.Text = (operand1 + operand2).ToString();
                    // MessageBox.Show("Addition: " + textBox3.Text);
                    break;

                case '-':
                    textBox3.Text = (operand1 - operand2).ToString();
                    // MessageBox.Show("Subtraction :" + textBox3.Text);
                    break;

                case '*':
                    textBox3.Text = (operand1 * operand2).ToString();
                    // MessageBox.Show("Multiplication :" + textBox3.Text);
                    break;

                case '/':
                    textBox3.Text = (operand1 / operand2).ToString();
                    // MessageBox.Show("Division :" + textBox3.Text);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Enter Valid Input");
        }
    }

}
