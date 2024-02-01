namespace WinformDemo;

partial class CRUDdemo
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
        this.ClientSize = new System.Drawing.Size(1300, 770);
        this.Text = "CRUDdemo";

        this.Label0 = new Label();
        this.Label0.AutoSize = true;
        this.Label0.Text = "Book ID";
        this.Label0.Location = new System.Drawing.Point(28, 28);
        this.Label0.Size = new System.Drawing.Size(62, 20);
        this.Controls.Add(this.Label0);

        this.Label2 = new Label();
        this.Label2.AutoSize = true;
        this.Label2.Text = "Book Name";
        this.Label2.Location = new System.Drawing.Point(28, 68);
        this.Label2.Size = new System.Drawing.Size(87, 20);
        this.Label2.TabIndex = 2;
        this.Controls.Add(this.Label2);

        this.Label3 = new Label();
        this.Label3.AutoSize = true;
        this.Label3.Text = "Author";
        this.Label3.Location = new System.Drawing.Point(32, 108);
        this.Label3.Size = new System.Drawing.Size(54, 20);
        this.Label3.TabIndex = 3;
        this.Controls.Add(this.Label3);

        this.Label4 = new Label();
        this.Label4.AutoSize = true;
        this.Label4.Text = "Price";
        this.Label4.Location = new System.Drawing.Point(32, 148);
        this.Label4.Size = new System.Drawing.Size(41, 20);
        this.Label4.TabIndex = 4;
        this.Controls.Add(this.Label4);

        this.Label5 = new Label();
        this.Label5.AutoSize = true;
        this.Label5.Text = "Pages";
        this.Label5.Location = new System.Drawing.Point(32, 188);
        this.Label5.Size = new System.Drawing.Size(47, 20);
        this.Label5.TabIndex = 5;
        this.Controls.Add(this.Label5);

        this.TextBox6 = new TextBox();
        // this.TextBox6.Text = "TextBox1";
        this.TextBox6.Location = new System.Drawing.Point(176, 24);
        this.TextBox6.TabIndex = 6;
        this.Controls.Add(this.TextBox6);

        this.TextBox7 = new TextBox();
        // this.TextBox7.Text = "TextBox2";
        this.TextBox7.Location = new System.Drawing.Point(176, 64);
        this.TextBox7.TabIndex = 7;
        this.Controls.Add(this.TextBox7);


        this.TextBox8 = new TextBox();
        // this.TextBox8.Text = "TextBox3";
        this.TextBox8.Location = new System.Drawing.Point(176, 104);
        this.TextBox8.TabIndex = 8;
        this.Controls.Add(this.TextBox8);

        this.TextBox9 = new TextBox();
        // this.TextBox9.Text = "TextBox4";
        this.TextBox9.Location = new System.Drawing.Point(176, 144);
        this.TextBox9.TabIndex = 9;
        this.Controls.Add(this.TextBox9);

        this.TextBox10 = new TextBox();
        // this.TextBox10.Text = "TextBox5";
        this.TextBox10.Location = new System.Drawing.Point(176, 184);
        this.TextBox10.TabIndex = 10;
        this.Controls.Add(this.TextBox10);

        this.Button11 = new Button();
        this.Button11.Text = "Insert";
        this.Button11.Location = new System.Drawing.Point(36, 240);
        this.Button11.Size = new System.Drawing.Size(76, 32);
        this.Button11.TabIndex = 11;
        this.Controls.Add(this.Button11);
        this.Button11.Click += new EventHandler(this.button11_click);

        this.Button12 = new Button();
        this.Button12.Text = "Update";
        this.Button12.Location = new System.Drawing.Point(136, 240);
        this.Button12.Size = new System.Drawing.Size(76, 32);
        this.Button12.TabIndex = 12;
        this.Controls.Add(this.Button12);
        this.Button12.Click += new EventHandler(this.button12_click);

        this.Button13 = new Button();
        this.Button13.Text = "Delete";
        this.Button13.Location = new System.Drawing.Point(236, 240);
        this.Button13.Size = new System.Drawing.Size(76, 32);
        this.Button13.TabIndex = 13;
        this.Controls.Add(this.Button13);
        this.Button13.Click += new EventHandler(this.button13_click);

        this.Button14 = new Button();
        this.Button14.Text = "Read";
        this.Button14.Location = new System.Drawing.Point(336, 240);
        this.Button14.Size = new System.Drawing.Size(76, 32);
        this.Button14.TabIndex = 14;
        this.Controls.Add(this.Button14);
        this.Button14.Click += new EventHandler(this.btnRead_Click);

        this.Button15 = new Button();
        this.Button15.Text = "Write";
        this.Button15.Location = new System.Drawing.Point(436, 240);
        this.Button15.Size = new System.Drawing.Size(76, 32);
        this.Button15.TabIndex = 15;
        this.Controls.Add(this.Button15);
        this.Button15.Click += new EventHandler(this.btnWrite_Click);

        this.Button16 = new Button();
        this.Button16.Text = "ReadInCSV";
        this.Button16.Location = new System.Drawing.Point(536, 240);
        this.Button16.Size = new System.Drawing.Size(76, 32);
        this.Button16.TabIndex = 16;
        this.Controls.Add(this.Button16);
        this.Button16.Click += new EventHandler(this.Button16_Click);

        this.Button17 = new Button();
        this.Button17.Text = "WriteInCSV";
        this.Button17.Location = new System.Drawing.Point(636, 240);
        this.Button17.Size = new System.Drawing.Size(76, 32);
        this.Button17.TabIndex = 17;
        this.Controls.Add(this.Button17);
        this.Button17.Click += new EventHandler(this.Button17_Click);

        this.Button18 = new Button();
        this.Button18.Text = "WriteInpdf";
        this.Button18.Location = new System.Drawing.Point(736, 240);
        this.Button18.Size = new System.Drawing.Size(76, 32);
        this.Button18.TabIndex = 18;
        this.Controls.Add(this.Button18);
        this.Button18.Click += new EventHandler(this.printDatabase);

        this.Button19 = new Button();
        this.Button19.Text = "Font";
        this.Button19.Location = new System.Drawing.Point(836, 240);
        this.Button19.Size = new System.Drawing.Size(76, 32);
        this.Button19.TabIndex = 19;
        this.Controls.Add(this.Button19);
        this.Button19.Click += new EventHandler(this.Button19_Click);

        this.Button20 = new Button();
        this.Button20.Text = "Color";
        this.Button20.Location = new System.Drawing.Point(936, 240);
        this.Button20.Size = new System.Drawing.Size(76, 32);
        this.Button20.TabIndex = 20;
        this.Controls.Add(this.Button20);
        this.Button20.Click += new EventHandler(this.Button20_Click);


        this.progressBar1 = new ProgressBar();
        this.progressBar1.Location = new System.Drawing.Point(800, 350);
        this.progressBar1.Size = new System.Drawing.Size(300, 23);
        this.progressBar1.TabIndex = 21;
        this.Controls.Add(this.progressBar1);

        this.dataGridView1 = new DataGridView();
        this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new Point(36, 350);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowHeadersWidth = 51;
        this.dataGridView1.RowTemplate.Height = 29;
        this.dataGridView1.Size = new Size(700, 400);
        this.dataGridView1.TabIndex = 0;
        this.Controls.Add(this.dataGridView1);
        this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.DataGridViewCellClick);
    }

    #endregion
}
