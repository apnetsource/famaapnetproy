using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace APNETDesktop
{
    /// <summary>
    /// Lógica de interacción para Dosificador.xaml
    /// </summary>
    public partial class Dosificador : Window
    {
        public Dosificador()
        {
            InitializeComponent();
        }

        

            private void btnPinPanel_Click(object sender, RoutedEventArgs e)
        {
            //_mainFrame.NavigationService.Navigate("Distribuidor.xaml");

            this.Content = new Distribuidor();

            ////_mainFrame.NavigationService.Navigate(new Uri("MainWindow.xaml", UriKind.Relative));

            //Cliente page2Obj = new Cliente(); //Create object of Page2
            //page2Obj.Show(); //Show page2
            //this.Close(); //this will close Page1

        }

    }
}
