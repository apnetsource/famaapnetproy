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
using FAMA.AP.Desktop.View.ADMIN;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class TiemposOperacion : Window
    {
        private Header _Header;

        public TiemposOperacion()
        {

            InitializeComponent();

            myHeader.Children.Clear();
            _Header = new Header();
            myHeader.Children.Add(_Header);

        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            FAMA.AP.Desktop.View.HomeView newWin = new HomeView();
            newWin.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            FAMA.AP.Desktop.View.HomeView newWin = new HomeView();
            newWin.Show();
            this.Close();

        }

    }
}
