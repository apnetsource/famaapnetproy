using System.Windows;
using System.Windows.Media;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para HomeView.xaml
    /// </summary>
    public partial class TiemposOperacionA : Window
    {
        public bool status = false;
        private Header _Header;
        private SectionsBar _SectionsBar;

        public TiemposOperacionA()
        {
            InitializeComponent();
            myHeader.Children.Clear();
            _Header = new Header();
            myHeader.Children.Add(_Header);

            sectionBar.Children.Clear();
            _SectionsBar = new SectionsBar();
            sectionBar.Children.Add(_SectionsBar);


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

        //private void btn_sec1_Click(object sender, RoutedEventArgs e)
        //{
        //    status = false;
        //    if (status == false)
        //    {
        //        btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec2_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec3_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec4_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec5_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec6_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec7_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec8_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec9_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec10_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec11_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}

        //private void btn_sec12_Click(object sender, RoutedEventArgs e)
        //{
        //    status = true;
        //    if (status == true)
        //    {
        //        btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
        //    }
        //    //else
        //    //{
        //    //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    //}
        //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //    btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        //}
    }
}
