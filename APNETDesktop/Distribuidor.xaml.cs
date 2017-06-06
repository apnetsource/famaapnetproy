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

namespace APNETDesktop
{
    /// <summary>
    /// Lógica de interacción para Distribuidor.xaml
    /// </summary>
    public partial class Distribuidor : Window
    {
        public Distribuidor()
        {
            InitializeComponent();
        }


        private void btnPinPanel_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.NavigationService.Navigate("MainWindow.xaml");
            //this.Close();

            //Cliente page2Obj = new Cliente(); //Create object of Page2
            //page2Obj.Show(); //Show page2
            //this.Close(); //this will close Page1

        }
    }
}
