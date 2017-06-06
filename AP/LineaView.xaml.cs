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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FAMA.AP.Desktop.View.SERVOMEC;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para LineaView.xaml
    /// </summary>
    public partial class LineaView : UserControl
    {
        public LineaView()
        {
            InitializeComponent();
        }

        private void DosificadorButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NavegacionServoMecView();
        }

        private void DistribuidorButton_Click(object sender, RoutedEventArgs e)
        {
            //this.Content = new DistribuidorView();
            this.Content = new NavegacionServoMecView();
        }

        private void ClienteButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NavegacionServoMecView();
        }

        private void EmpujadorButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NavegacionServoMecView();
        }

        private void MotorizacionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NavegacionServoMecView();
        }

        private void CEISButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new NavegacionServoMecView();
        }

    }
}
