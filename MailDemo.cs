using System.Data;
using System.Windows.Forms;
using Npgsql;
using Microsoft.VisualBasic.FileIO;
using iText.Kernel.Pdf;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Net;

namespace WinformDemo;

public partial class MailDemo : Form
{

    private Label Label1, Label2, Label3, Label4, Label5;
    private TextBox TextBox1, TextBox2, TextBox3, TextBox4, TextBox5;
    private Button Button1, Button2;
    private OpenFileDialog openFileDialog1;
    private Label lblAttach;

    private void btnSendMail_click(object sender, EventArgs e)
    {
        MailMessage msg = new MailMessage();
        msg.From = new MailAddress("jankigabani14@gmail.com");
        msg.To.Add(TextBox2.Text);
        msg.Subject = TextBox3.Text;
        msg.Body = TextBox4.Text;
        foreach (string filePath in openFileDialog1.FileNames)
        {
            if (File.Exists(filePath))
            {
                string fileName = Path.GetDirectoryName(filePath);
                msg.Attachments.Add(new Attachment(filePath));
            }

        }
        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.gmail.com";
        smtp.Port = 587;
        smtp.EnableSsl = true;

        NetworkCredential ntcd = new NetworkCredential();
        ntcd.UserName = "jankigabani14@gmail.com";
        ntcd.Password = "zuqb ovcg hesx pquj";
        // ntcd.Password = TextBox5.Text;s
        smtp.Credentials = ntcd;

        try
        {
            smtp.Send(msg);
            MessageBox.Show("Mail Sent Successfully" + " " + TextBox2.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to send the mail:" + ex.Message);
        }

        clearText();
    }

    private void clearText()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
    }

    private void btnAttach_Click(object sender, EventArgs e)
    {
        openFileDialog1.FileName = "";
        openFileDialog1.Multiselect = true;
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            foreach (string filePath in openFileDialog1.FileNames)
            {
                if (File.Exists(filePath))
                {
                    string fileName = Path.GetFileName(filePath);
                    lblAttach.Text += fileName + ", ";
                }
            }
        }
    }

    public MailDemo()
    {
        InitializeComponent();
    }

}
