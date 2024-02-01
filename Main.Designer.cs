namespace WinformDemo;

public partial class Main{
    private System.ComponentModel.IContainer  components = null;

    protected override void Dispose(bool disposing){
        if(disposing && (components != null)){
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private MenuStrip menuStrip;
    private ToolStripMenuItem email;
     private ToolStripMenuItem Crud;
      private ToolStripMenuItem Cal;
      private ToolStripMenuItem DT;



    private void InitializeComponent(){

        this.components=new System.ComponentModel.Container();
       menuStrip = new MenuStrip();
       email = new ToolStripMenuItem();
       Crud = new ToolStripMenuItem();
       Cal = new ToolStripMenuItem();
       DT = new ToolStripMenuItem();


       email.Text = "Email";
       email.Click += new EventHandler(this.email_project);
       Crud.Text = "Crud";
       Crud.Click += new EventHandler(this.Crud_project);
       Cal.Text = "Calculator";
       Cal.Click += new EventHandler(this.Calculator_project);
       DT.Text = "DataTransfer";
       DT.Click += new EventHandler(this.DataTransfer_Project);

       menuStrip.Items.AddRange(new ToolStripItem[] {email,Crud,Cal,DT});

      Controls.Add(menuStrip);

    }
}