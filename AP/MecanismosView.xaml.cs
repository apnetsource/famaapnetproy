using System.Windows;
using System.Windows.Media;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Controls;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class MecanismosView : Window
    {
        public bool status = false;
        private Header _Header;
        private SectionsBar _SectionsBar;

        public MecanismosView()
        {
            InitializeComponent();
            //myHeader.Children.Clear();
            //_Header = new Header();
            //myHeader.Children.Add(_Header);

            //sectionBar.Children.Clear();
            //_SectionsBar = new SectionsBar();
            //sectionBar.Children.Add(_SectionsBar);


            //btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
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

        //private void btn_save_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btn_cancel_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btn_add_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void btn_edit_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
