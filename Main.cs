namespace WinformDemo;
public partial class Main : Form{

    public Main(){
        InitializeComponent();
        IsMdiContainer = true;
    }

    private void email_project(object sender,EventArgs e){
        this.Hide();
        MailDemo email = new MailDemo();
        email.FormClosed += (s,args) =>this.Show();
        email.Show();
    }

     private void Crud_project(object sender,EventArgs e){
        this.Hide();
        CRUDdemo Crud = new CRUDdemo();
        Crud.FormClosed += (_,_) =>this.Show();
        Crud.Show();
     }
      private void Calculator_project(object sender,EventArgs e){
        this.Hide();
        Form1 form1 = new Form1();
        form1.FormClosed += (_,_) =>this.Show();
        form1.Show();
      }

      private void DataTransfer_Project(object sender,EventArgs e){
        this.Hide();
        DataTransfer dt = new DataTransfer();
        dt.FormClosed += (_,_) =>this.Show();
        dt.Show();
      }
}