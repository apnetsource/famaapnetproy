using System.Windows.Controls;
using FAMA.AP.ViewModel;

namespace FAMA.AP.Desktop.View.ADMIN
{
    /// <summary>
    /// Lógica de interacción para Client.xaml
    /// </summary>
    public partial class ClientView : UserControl
    {

        public ClientView()
        {
            InitializeComponent();

        }

        private void btn_edit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txt_client.IsEnabled = true;
            txt_country.IsEnabled = true;
            txt_city.IsEnabled = true;
            txt_locality.IsEnabled = true;
            txt_plant.IsEnabled = true;
            txt_line.IsEnabled = true;
            txt_oven.IsEnabled = true;
        }

        private void btn_cancel_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            txt_client.IsEnabled = false;
            txt_country.IsEnabled = false;
            txt_city.IsEnabled = false;
            txt_locality.IsEnabled = false;
            txt_plant.IsEnabled = false;
            txt_line.IsEnabled = false;
            txt_oven.IsEnabled = false;
        }
    }
}
