using System.Data;
using System.Windows.Forms;
using Npgsql;
using Microsoft.VisualBasic.FileIO;
using iText.Kernel.Pdf;
using System.Drawing.Printing;

namespace WinformDemo;

public partial class CRUDdemo : Form
{

    private Label Label0, Label2, Label3, Label4, Label5;
    private TextBox TextBox6, TextBox7, TextBox8, TextBox9, TextBox10;
    private Button Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20;
    private DataGridView dataGridView1;
    private ProgressBar progressBar1;
    private FontDialog fontDialog1 = new FontDialog();
    private ColorDialog colorDialog1 = new ColorDialog();
    private NpgsqlConnection cn = new NpgsqlConnection("Server=cipg01;port=5432;Database=GroupG;Username=postgres;Password=123456;");

    private readonly OpenFileDialog openFileDialog = new OpenFileDialog();
    private readonly SaveFileDialog saveFileDialog = new SaveFileDialog();

    private void LoadData()
    {
        NpgsqlCommand cmd = new NpgsqlCommand("select * from t_book", cn);

        try
        {
            cn.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
        }
        catch (Exception e)
        {

            MessageBox.Show("Error: " + e.Message);

        }
        finally
        {
            cn.Close();
        }

    }

    private void button11_click(object sender, EventArgs e)
    {

        NpgsqlCommand cmd2 = new NpgsqlCommand("INSERT INTO t_book (c_bookname, c_author, c_price, c_pages) VALUES (@book_name, @book_author, @book_price, @book_pages)", cn);
        cmd2.Parameters.AddWithValue("@book_name", TextBox7.Text);
        cmd2.Parameters.AddWithValue("@book_author", TextBox8.Text);
        cmd2.Parameters.AddWithValue("@book_price", Convert.ToInt32(TextBox9.Text));
        cmd2.Parameters.AddWithValue("@book_pages", Convert.ToInt32(TextBox10.Text));

        try
        {
            cn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

        }
        finally
        {
            cn.Close();
        }

        clearTextBox();
        LoadData();

    }

    private void button12_click(object sender, EventArgs e)
    {

        NpgsqlCommand cmd2 = new NpgsqlCommand("UPDATE t_book SET c_bookname = @book_name, c_author = @book_author, c_price = @book_price, c_pages = @book_pages WHERE c_bookid = @book_id ", cn);
        cmd2.Parameters.AddWithValue("@book_id", Convert.ToInt32(TextBox6.Text));
        cmd2.Parameters.AddWithValue("@book_name", TextBox7.Text);
        cmd2.Parameters.AddWithValue("@book_author", TextBox8.Text);
        cmd2.Parameters.AddWithValue("@book_price", Convert.ToInt32(TextBox9.Text));
        cmd2.Parameters.AddWithValue("@book_pages", Convert.ToInt32(TextBox10.Text));

        try
        {
            cn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

        }
        finally
        {
            cn.Close();
        }

        clearTextBox();
        LoadData();

    }

    private void button13_click(object sender, EventArgs e)
    {

        NpgsqlCommand cmd2 = new NpgsqlCommand("DELETE FROM t_book WHERE c_bookid = @book_id ", cn);
        cmd2.Parameters.AddWithValue("@book_id", Convert.ToInt32(TextBox6.Text));
        cmd2.Parameters.AddWithValue("@book_name", TextBox7.Text);
        cmd2.Parameters.AddWithValue("@book_author", TextBox8.Text);
        cmd2.Parameters.AddWithValue("@book_price", Convert.ToInt32(TextBox9.Text));
        cmd2.Parameters.AddWithValue("@book_pages", Convert.ToInt32(TextBox10.Text));

        try
        {
            cn.Open();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Record Deleted Successfully");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);

        }
        finally
        {
            cn.Close();
        }

        clearTextBox();
        LoadData();

    }
    private void btnRead_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        openFileDialog.FileName = "";
        openFileDialog.Filter = "XML Files|*.xml|All Files|*.*";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            ds.ReadXml(openFileDialog.FileName);
            dataGridView1.DataSource = ds.Tables[0];
            SaveDataToDatabase(ds.Tables[0]);
        }
    }

    private void SaveDataToDatabase(DataTable dataTable)
    {
        try
        {
            cn.Open();

            foreach (DataRow row in dataTable.Rows)
            {
                int b_i = Convert.ToInt32(row["c_bookid"]);
                string? b_n = row["c_bookname"].ToString();
                string? b_a = row["c_author"].ToString();
                int b_p = Convert.ToInt32(row["c_price"]);
                int b_pg = Convert.ToInt32(row["c_pages"]);

                NpgsqlCommand cm = new NpgsqlCommand("INSERT INTO t_book (c_bookname, c_author, c_price, c_pages) VALUES (@book_name, @book_author, @book_price, @book_pages)", cn);
                cm.Parameters.AddWithValue("@book_name", b_n);
                cm.Parameters.AddWithValue("@book_author", b_a);
                cm.Parameters.AddWithValue("@book_price", b_p);
                cm.Parameters.AddWithValue("@book_pages", b_pg);

                cm.ExecuteNonQuery();

            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cn.Close();
        }
        MessageBox.Show("Data saved to the database successfully!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
        try
        {
            cn.Open();
            NpgsqlCommand cm = new NpgsqlCommand("select * from t_book", cn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cm);

            saveFileDialog.Filter = "XML Files|*.xmL| All Files|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataSet ds = new DataSet();
                da.Fill(ds, "t_book");
                ds.WriteXml(saveFileDialog.FileName);
                MessageBox.Show("File written successfully!", "Write", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    private void Button16_Click(object sender, EventArgs e)
    {
        try
        {
            openFileDialog.FileName = "";
            openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = ReadCSV(openFileDialog.FileName);
                dataGridView1.DataSource = dt;
                SaveDataToDatabase(dt);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    private DataTable ReadCSV(string filePath)
    {
        DataTable dt = new DataTable();

        try
        {
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Assuming the first row in CSV contains column names
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    dt.Columns.Add(new DataColumn(field));
                }

                while (!parser.EndOfData)
                {
                    fields = parser.ReadFields();
                    dt.Rows.Add(fields);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error reading CSV: " + ex.Message);
        }

        return dt;
    }

    private void Button17_Click(object sender, EventArgs e)
    {
        try
        {
            saveFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WriteCSV(saveFileDialog.FileName);
                MessageBox.Show("Data written to CSV successfully!", "Write CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
        finally
        {
            cn.Close();
        }
    }

    private void WriteCSV(string filePath)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // Write column headers
                List<string> headers = new List<string>();
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    headers.Add(column.HeaderText);
                }
                sw.WriteLine(string.Join(",", headers));

                // Write data rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    List<string> fields = new List<string>();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        fields.Add(cell.Value?.ToString() ?? ""); // Handle possible null values
                    }
                    sw.WriteLine(string.Join(",", fields));
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error writing CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void printDatabase(object sender, EventArgs e)
    {
        PrintDocument pd = new PrintDocument();
        pd.PrintPage += new PrintPageEventHandler(printPage);
        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        printPreviewDialog.Document = pd;
        printPreviewDialog.ShowDialog();
    }

    // Method to handle the printing of the database content
    private void printPage(object sender, PrintPageEventArgs e)
    {
        Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
        this.dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

        e.Graphics.DrawImage(bm, 0, 0);
    }
    private void clearTextBox()
    {
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
    }

    private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            TextBox6.Text = row.Cells["c_bookid"].Value.ToString();
            TextBox7.Text = row.Cells["c_bookname"].Value.ToString();
            TextBox8.Text = row.Cells["c_author"].Value.ToString();
            TextBox9.Text = row.Cells["c_price"].Value.ToString();
            TextBox10.Text = row.Cells["c_pages"].Value.ToString();
        }
    }

    private void Button19_Click(object sender, EventArgs e)
    {
        fontDialog1.ShowColor = true;
        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            dataGridView1.Font = fontDialog1.Font;
            dataGridView1.ForeColor = fontDialog1.Color;
        }

    }
    private void Button20_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            dataGridView1.GridColor = colorDialog1.Color;
            // dataGridView1.RowsDefaultCellStyle.BackColor = colorDialog1.Color;
        }
    }

    // private void ChangeColor(object sender, EventArgs e)
    // {
    //     if(colorDialog1.ShowDialog() == DialogResult.OK)
    //     {
    //         dataGridView1.BackgroundColor = colorDialog1.Color;
    //         foreach(DataGridViewRow dataGridViewRow in dataGridView1.SelectedRows)
    //         {
    //             dataGridViewRow.DefaultCellStyle.BackColor = colorDialog1.Color;
    //         }
    //     }
    // }

    private bool IsValidationPassed = true;

    private void TextBox_TextChanged(object sender, EventArgs e)
    {
        ValidateInputs();
        UpdateProgressBar();
    }

    private void ValidateInputs()
    {
        IsValidationPassed = true; 

        if (TextBox8.Visible && !IsValidAuthorName(TextBox8.Text))
        {
            IsValidationPassed = false;
            MessageBox.Show("Author name should contain only alphabets.");
            return;
        }

        if (TextBox9.Visible && !IsValidNumber(TextBox9.Text))
        {
            IsValidationPassed = false;
            MessageBox.Show("Price should contain only numbers.");
            return;
        }

        if (TextBox10.Visible && !IsValidNumber(TextBox10.Text))
        {
            IsValidationPassed = false;
            MessageBox.Show("Pages should contain only numbers.");
            return;
        }
    }

    private void UpdateProgressBar()
    {
        if (IsValidationPassed)
        {
            int progress = CalculateProgress();
            progressBar1.Value = progress;
        }
    }

    private bool IsValidAuthorName(string authorName)
    {
        return string.IsNullOrEmpty(authorName) || authorName.All(char.IsLetter);
    }

    private bool IsValidNumber(string input)
    {
        return string.IsNullOrEmpty(input) || int.TryParse(input, out _);
    }

    private int CalculateProgress()
    {
        int totalFields = 5;
        int filledFields = 0;

        if (!string.IsNullOrWhiteSpace(TextBox6.Text))
            filledFields++;

        if (!string.IsNullOrWhiteSpace(TextBox7.Text))
            filledFields++;

        if (!string.IsNullOrWhiteSpace(TextBox8.Text))
            filledFields++;

        if (!string.IsNullOrWhiteSpace(TextBox9.Text))
            filledFields++;

        if (!string.IsNullOrWhiteSpace(TextBox10.Text))
            filledFields++;

        return (filledFields * 100) / totalFields;
    }
    public CRUDdemo()
    {
        InitializeComponent();
        LoadData();
        TextBox6.TextChanged += TextBox_TextChanged;
        TextBox7.TextChanged += TextBox_TextChanged;
        TextBox8.TextChanged += TextBox_TextChanged;
        TextBox9.TextChanged += TextBox_TextChanged;
        TextBox10.TextChanged += TextBox_TextChanged;
    }

}
