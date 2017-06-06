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

namespace FAMA.AP.Desktop.View.SERVOMEC
{
    /// <summary>
    /// Lógica de interacción para NavegacionServoMecView.xaml
    /// </summary>
    public partial class NavegacionServoMecView : UserControl
    {
        private CEISView _CEISView;
        private ClienteView _ClienteView;
        private DistribuidorView _DistribuidorView;
        private DosificadorView _DosificadorView;
        private EmpujadorView _EmpujadorView;
        private MotorizacionView _MotorizacionView;

        public NavegacionServoMecView()
        {
            InitializeComponent();

            InitializeComponent();
            mySM_Panel.Children.Clear();

        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _ClienteView = new ClienteView();
            mySM_Panel.Children.Add(_ClienteView);

        }

        private void btnDistribuidor_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _DistribuidorView = new DistribuidorView();
            mySM_Panel.Children.Add(_DistribuidorView);

        }

        private void btnDosificador_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _DosificadorView = new DosificadorView();
            mySM_Panel.Children.Add(_DosificadorView);

        }

        private void btnEmpujador_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _EmpujadorView = new EmpujadorView();
            mySM_Panel.Children.Add(_EmpujadorView);

        }

        private void btnMotorizacion_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _MotorizacionView = new MotorizacionView();
            mySM_Panel.Children.Add(_MotorizacionView);

        }

        private void btnCEIS_Click(object sender, RoutedEventArgs e)
        {
            mySM_Panel.Children.Clear();
            _CEISView = new CEISView();
            mySM_Panel.Children.Add(_CEISView);

        }

    }
}
