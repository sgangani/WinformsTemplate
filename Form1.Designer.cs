namespace WinformDemo;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";


        this.label1 = new System.Windows.Forms.Label();
        this.label1.Location = new System.Drawing.Point(100, 120);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(150, 30);
        this.label1.Text = "Number 1";
        this.label1.ForeColor = System.Drawing.Color.Blue;
        this.Controls.Add(this.label1);

        this.label2 = new System.Windows.Forms.Label();
        this.label2.Location = new System.Drawing.Point(100, 180);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(150, 30);
        this.label2.Text = "Number 2";
        this.label2.ForeColor = System.Drawing.Color.Blue;
        this.Controls.Add(this.label2);

        this.label3 = new System.Windows.Forms.Label();
        this.label3.Location = new System.Drawing.Point(100, 240);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(150, 30);
        this.label3.Text = "Result";
        this.label3.ForeColor = System.Drawing.Color.Green;
        this.Controls.Add(this.label3);

        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox1.Location = new System.Drawing.Point(300,120);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(150,30);
        this.Controls.Add(this.textBox1);

        this.textBox2 = new System.Windows.Forms.TextBox();
        this.textBox2.Location = new System.Drawing.Point(300,180);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(150,30);
        this.Controls.Add(this.textBox2);

        this.textBox3 = new System.Windows.Forms.TextBox();
        this.textBox3.Location = new System.Drawing.Point(300,240);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(150,30);
        this.Controls.Add(this.textBox3);

        this.button1 = new System.Windows.Forms.Button();
        this.button1.Location = new System.Drawing.Point(100, 300);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(60, 40);
        this.button1.Text = "+";
        this.button1.Click += new System.EventHandler(this.Addition);
        this.Controls.Add(this.button1);

        this.button2 = new System.Windows.Forms.Button();
        this.button2.Location = new System.Drawing.Point(200, 300);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(60, 40);
        this.button2.Text = "-";
        this.button2.Click += new System.EventHandler(this.Subtraction);
        this.Controls.Add(this.button2);

        this.button3 = new System.Windows.Forms.Button();
        this.button3.Location = new System.Drawing.Point(300, 300);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(60, 40);
        this.button3.Text = "/";
        this.button3.Click += new System.EventHandler(this.Division);
        this.Controls.Add(this.button3);

        this.button4 = new System.Windows.Forms.Button();
        this.button4.Location = new System.Drawing.Point(400, 300);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(60, 40);
        this.button4.Text = "*";
        this.button4.Click += new System.EventHandler(this.Multiplication);
        this.Controls.Add(this.button4);

    }

    #endregion
}
