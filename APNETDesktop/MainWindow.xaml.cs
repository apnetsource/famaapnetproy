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

namespace APNETDesktop
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, RoutedEventArgs e)
        {
            //_mainFrame.NavigationService.GoForward();
            //////or
            _mainFrame.NavigationService.Navigate("Distribuidor.xaml");
        }


        private void MenuDisplay_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar ventana insertar
            TestWindow wDisplay = new TestWindow();
            //wDisplay.Show();
        }

        //void item1_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        //{
        //    e.Handled = true;
        //    this.item1.IsSubmenuOpen = true;
        //}

    }
}




