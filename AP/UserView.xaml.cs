using System;
using System.Windows.Controls;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para addUser.xaml
    /// </summary>
    public partial class UserView: UserControl
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void txtPsw_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            //int ascci = System.Convert.ToInt32(System.Convert.ToChar(e.Text));
            //if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)
            //    e.Handled = false;
            //else
            //    e.Handled = true;
        }

        private void txtName_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            int ascci = System.Convert.ToInt32(System.Convert.ToChar(e.Text));
            if (ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
