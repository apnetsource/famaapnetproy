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
using FAMA.AP.Desktop.View.ADMIN;


namespace FAMA.AP.Desktop.View.USERCTL
{
    /// <summary>
    /// Lógica de interacción para SecctionsView.xaml
    /// </summary>
    public partial class SectionsView : UserControl
    {
        public bool status = false;
        public SectionsView()
        {

            InitializeComponent();

            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            set_ini_btn();

        }


        private void btn_sec1_Click(object sender, RoutedEventArgs e)
        {
            status = false;
            if (status == false)
            {
                btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec2_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec3_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec4_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec5_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec6_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec7_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec8_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec9_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec10_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec11_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }

        private void btn_sec12_Click(object sender, RoutedEventArgs e)
        {
            status = true;
            if (status == true)
            {
                btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            //else
            //{
            //    btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            //}
            btn_sec1.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }


        private void set_ini_btn()
        {
            btn_sec2.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec3.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec4.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec5.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec6.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec7.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec8.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec9.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec10.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec11.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
            btn_sec12.Background = new SolidColorBrush(Color.FromArgb(255, 40, 127, 193));
        }
    }
}
