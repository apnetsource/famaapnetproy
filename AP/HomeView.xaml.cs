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
    public partial class HomeView : Window
    {
        private UserView _UserView;
        private Control _currentUserControl;
        private LineaView _Linea;
        private Header _Header;
        private ClientView _ClientView;
        private ProcessTypeView _ProcessTypeView;
        private CeisView _CeisView;
        //private TiemposOperacion _TiempoOperacion;
        
        public HomeView()
        {

            InitializeComponent();

            myHeader.Children.Clear();
            _Header = new Header();
            myHeader.Children.Add(_Header);

            myStack.Children.Clear();
            this.spnlMenu.Visibility = Visibility.Hidden;

            _Linea = new LineaView();
            myStack.Children.Add(_Linea);
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            string valor = spnlMenu.Visibility.ToString();
            if (valor == "Visible")
            {
                this.spnlMenu.Visibility = Visibility.Hidden;
            }
            else
            {
                this.spnlMenu.Visibility = Visibility.Visible;
                configOff();
                processOff();
            }
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();
            this.spnlMenu.Visibility = Visibility.Hidden;

            _Linea = new LineaView();
            myStack.Children.Add(_Linea);

        }

        private void btnAlarmas_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();
            configOff();
            processOff();

        }

        private void btnConfig_Click(object sender, RoutedEventArgs e)
        {
            //myStack.Children.Clear();
            string valor = spnlMenuConfiguracion.Visibility.ToString();
            if (valor == "Visible")
            {
                this.spnlMenuConfiguracion.Visibility = Visibility.Hidden;
                configOff();
            }
            else
            {

                this.spnlMenuConfiguracion.Visibility = Visibility.Visible;
                configOn();
                processOff();
            }

        }

        private void btnGrafica_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();
            configOff();
            processOff();

        }

        private void btnProceso_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();
            string valor = spnlMenuProcesos.Visibility.ToString();
            if (valor == "Visible")
            {
                this.spnlMenuProcesos.Visibility = Visibility.Hidden;
                processOff();
            }
            else
            {
                this.spnlMenuProcesos.Visibility = Visibility.Visible;
                processOn();
                configOff();
            }

        }



        private void btnLinea_Click(object sender, RoutedEventArgs e)
        {

            myStack.Children.Clear();

            //_UserView = new UserView();
            //_currentUserControl = _UserView;
            //myStack.Children.Add(_currentUserControl);
            //this.spnlMenu.Visibility = Visibility.Hidden;

        }

        private void btnCeis_Click(object sender, RoutedEventArgs e)
        {

            myStack.Children.Clear();
            _CeisView = new CeisView();
            _currentUserControl = _CeisView;
            myStack.Children.Add(_currentUserControl);
            this.spnlMenu.Visibility = Visibility.Hidden;
        }


        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {

            myStack.Children.Clear();

            _UserView = new UserView();
            _currentUserControl = _UserView;
            myStack.Children.Add(_currentUserControl);
            this.spnlMenu.Visibility = Visibility.Hidden;

        }


        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {

            myStack.Children.Clear();

            _ClientView = new ClientView();
            _currentUserControl = _ClientView;
            myStack.Children.Add(_currentUserControl);
            this.spnlMenu.Visibility = Visibility.Hidden;

        }

        private void btnTipoPros_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();

            _ProcessTypeView = new ProcessTypeView();
            _currentUserControl = _ProcessTypeView;
            myStack.Children.Add(_currentUserControl);
            this.spnlMenu.Visibility = Visibility.Hidden;
        }

        private void btnTiemposOperacion_Click(object sender, RoutedEventArgs e)
        {
            myStack.Children.Clear();

            FAMA.AP.Desktop.View.TiemposOperacionA newWin = new TiemposOperacionA();
            newWin.Show();
            this.Close();
        }


        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void configOff()
        {
            btnCambMoldura.Height = 0;
            btnLinea.Height = 0;
            btnProcCiclo.Height = 0;
            btnSenales.Height = 0;
            btnSiervos.Height = 0;
            btnTipoPros.Height = 0;
            btnUsuarios.Height = 0;
            btnCliente.Height = 0;
            btnCeis.Height = 0;
        }


        private void configOn()
        {
            btnCambMoldura.Height = 25;
            btnLinea.Height = 25;
            btnProcCiclo.Height = 25;
            btnSenales.Height = 25;
            btnSiervos.Height = 25;
            btnTipoPros.Height = 25;
            btnUsuarios.Height = 25;
            btnCliente.Height = 25;
            btnCeis.Height = 25;
        }


        private void processOff()
        {
            btnTiemposOperacion.Height = 0;
            btnCicloCeramico.Height = 0;
            btnContrapresion.Height = 0;
            btnRelMecanicas.Height = 0;
            btnTipoOperacion.Height = 0;
        }

        private void processOn()
        {
            btnTiemposOperacion.Height = 25;
            btnCicloCeramico.Height = 25;
            btnContrapresion.Height = 25;
            btnRelMecanicas.Height = 25;
            btnTipoOperacion.Height = 25;
        }

    }
}
