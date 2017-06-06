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

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para ModalView.xaml
    /// </summary>
    public partial class ModalView : UserControl
    {
        public ModalView()
        {
            //Esto va en el evento que lanza alguna edicion o borrado de datos.
            ////Window window = new Window
            ////{
            ////    Title = "My User Control Dialog Alert",
            ////    Content = new ModalView(),
            ////    Height = 200,  // just added to have a smaller control (Window)
            ////    Width = 240
            ////};

            //window.ShowDialog();

            InitializeComponent();
        }
        

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            lblAlert.ToolTip = "Ok...";
            
        }
    }
}
