namespace WinformDemo;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        #region CalculationDemo
        // Application.Run(new Form1());

        #endregion

        #region CRUDdemo
        Application.Run(new CRUDdemo());
        #endregion

        #region MailDemo
        // Application.Run(new DataTransfer());
        #endregion

    }    
}