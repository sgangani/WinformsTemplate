namespace WinformDemo;

partial class MailDemo
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
        this.ClientSize = new System.Drawing.Size(1000, 770);
        this.Text = "CRUDdemo";

        this.Label1 = new Label();
        this.Label1.AutoSize = true;
        this.Label1.Text = "From:";
        this.Label1.Location = new System.Drawing.Point(28, 28);
        this.Label1.Size = new System.Drawing.Size(62, 20);
        this.Controls.Add(this.Label1);

        this.Label2 = new Label();
        this.Label2.AutoSize = true;
        this.Label2.Text = "To:";
        this.Label2.Location = new System.Drawing.Point(28, 68);
        this.Label2.Size = new System.Drawing.Size(87, 20);
        this.Label2.TabIndex = 2;
        this.Controls.Add(this.Label2);

        this.Label3 = new Label();
        this.Label3.AutoSize = true;
        this.Label3.Text = "Subject:";
        this.Label3.Location = new System.Drawing.Point(32, 108);
        this.Label3.Size = new System.Drawing.Size(54, 20);
        this.Label3.TabIndex = 3;
        this.Controls.Add(this.Label3);

        this.Label4 = new Label();
        this.Label4.AutoSize = true;
        this.Label4.Text = "Message:";
        this.Label4.Location = new System.Drawing.Point(32, 148);
        this.Label4.Size = new System.Drawing.Size(41, 20);
        this.Label4.TabIndex = 4;
        this.Controls.Add(this.Label4);

        this.Label5 = new Label();
        this.Label5.AutoSize = true;
        this.Label5.Text = "Password:";
        this.Label5.Location = new System.Drawing.Point(32, 488);
        this.Label5.Size = new System.Drawing.Size(47, 20);
        this.Label5.TabIndex = 5;
        this.Controls.Add(this.Label5);

        this.lblAttach = new Label();
        this.lblAttach.Location = new System.Drawing.Point(32, 528);
        this.lblAttach.Size = new System.Drawing.Size(300, 40);
        this.Controls.Add(lblAttach);

        this.openFileDialog1 = new OpenFileDialog();
        // this.openFileDialog1.Multiselect = true;
        // this.openFileDialog1.Title += openFileDialog1_FileOk;

        this.TextBox1 = new TextBox();
        // this.TextBox1.Text = "TextBox1";
        this.TextBox1.Location = new System.Drawing.Point(176, 28);
        this.TextBox1.Size = new System.Drawing.Size(400, 20);
        this.TextBox1.TabIndex = 6;
        this.Controls.Add(this.TextBox1);

        this.TextBox2 = new TextBox();
        // this.TextBox2.Text = "TextBox2";
        this.TextBox2.Location = new System.Drawing.Point(176, 68);
        this.TextBox2.Size = new System.Drawing.Size(400, 20);
        this.TextBox2.TabIndex = 7;
        this.Controls.Add(this.TextBox2);


        this.TextBox3 = new TextBox();
        // this.TextBox3.Text = "TextBox3";
        this.TextBox3.Location = new System.Drawing.Point(176, 108);
        this.TextBox3.Size = new System.Drawing.Size(400, 20);
        this.TextBox3.TabIndex = 8;
        this.Controls.Add(this.TextBox3);

        this.TextBox4 = new TextBox();
        // this.TextBox4.Text = "TextBox4";
        this.TextBox4.Multiline = true;
        // this.TextBox4.ScrollBars = ScrollBars.Vertical;
        this.TextBox4.Location = new System.Drawing.Point(176, 148);
        this.TextBox4.Size = new System.Drawing.Size(400, 300);
        this.TextBox4.TabIndex = 9;
        this.Controls.Add(this.TextBox4);

        this.TextBox5 = new TextBox();
        // this.TextBox5.Text = "TextBox5";
        this.TextBox5.Location = new System.Drawing.Point(176, 488);
        this.TextBox5.Size = new System.Drawing.Size(400, 20);
        this.TextBox5.TabIndex = 10;
        this.TextBox5.UseSystemPasswordChar = true;
        this.Controls.Add(this.TextBox5);

        this.Button1 = new Button();
        this.Button1.Text = "Send Mail";
        this.Button1.Location = new System.Drawing.Point(36, 600);
        this.Button1.Size = new System.Drawing.Size(76, 32);
        this.Button1.TabIndex = 11;
        this.Controls.Add(this.Button1);
        this.Button1.Click += new EventHandler(this.btnSendMail_click);

        this.Button2 = new Button();
        this.Button2.Text = "Attach";
        this.Button2.Location = new System.Drawing.Point(136, 600);
        this.Button2.Size = new System.Drawing.Size(76, 32);
        this.Button2.TabIndex = 12;
        this.Controls.Add(this.Button2);
        this.Button2.Click += new EventHandler(this.btnAttach_Click);



    }

    #endregion
}
