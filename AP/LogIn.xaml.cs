using System;
using System.Linq;
using System.Windows;


namespace AP.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        { }
        //private void btnLogIn_Click(object sender, RoutedEventArgs e)
        //{
        //    User newUser = new User();
        //    try
        //    {

        //        loginDataContext dcxt = new loginDataContext();


        //        var UserFound = from Usr in dcxt.Users                                    
        //                                where  Usr.vcAccount == txtUserName.Text && Usr.vcPassword == txtPsw.Password 
        //                                select Usr;




        //        foreach (User p in UserFound)
        //        {
        //            //gregamos los datos correspondientes a la variable persona encontrada
        //            newUser = p;
        //        }

        //        // mostramos el valor de la persona encontrada
        //        if (newUser.vcAccount != null)
        //            MessageBox.Show("Acceso Autorizado");
        //        else
        //            MessageBox.Show("Usuario o password incorrecto, verificar sus credenciales.");


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //    finally
        //    {
        //        newUser = null;
        //        txtUserName.Text = "";
        //        txtPsw.Password = "";
        //    }
        //}
    }
}
