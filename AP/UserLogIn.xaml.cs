using System.Windows;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class UserLogIn : Window
    {
        public UserLogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text.Length > 0 && txtPsw.Password.Length > 0)
            {
                FAMA.AP.DataLayer.DbLogIn ln = new FAMA.AP.DataLayer.DbLogIn();
                if (ln.CheckUser(txtUserName.Text, txtPsw.Password) == 1)
                {
                    FAMA.AP.Desktop.View.HomeView newWin = new HomeView();
                    //FAMA.AP.Desktop.View.FamaMenu newWin = new FAMA.AP.Desktop.View.FamaMenu();
                    newWin.Show();
                    this.Close();
                }
                 
                else
                    txtStatus.Text = "User Name or Password are Invalid!";
            }
            else
                txtStatus.Text = "User Name and Password are Invalid!";
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
