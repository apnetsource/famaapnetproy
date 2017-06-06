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
using FAMA.AP.Model;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Interaction logic for Header.xaml
    /// </summary>
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
            /*** provisional hasta implementar la lectura de la maquina desde VIEW MODEL ***/
            HeaderData modelHeader = new HeaderData();
            this.txtBPM.Content = modelHeader.BPM;
            this.txtMold.Content = modelHeader.Mold;
            this.txtNombre.Content = modelHeader.FullName;
            this.txtVReal.Content = modelHeader.VReal;
            this.txtVTeorico.Content = modelHeader.VTeorico;
            this.txtVSeccion.Content = modelHeader.VSeccion;
            this.txtCicloReal.Content = modelHeader.VCicloReal;
            this.txtCicloTeo.Content = modelHeader.CicloTeo;
            this.txtSecOper.Content = modelHeader.SecOper;
            this.txtTime.Content = modelHeader.Time;
            this.txtDate.Content = modelHeader.Date;

        }
    }
}

