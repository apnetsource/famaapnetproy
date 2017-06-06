using System.Windows.Controls;
using System.Windows;
using System.Data;
using System.Windows.Controls.Primitives;
using System.Collections.Generic;
using System.Collections;
using System;

namespace FAMA.AP.Desktop.View
{
    /// <summary>
    /// Lógica de interacción para MechanismView.xaml
    /// </summary>
    public partial class MechanismView : UserControl
    {

        public MechanismView()
        {
            InitializeComponent();
        }

        private void DataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex() + 1).ToString();
        }
        
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

             foreach (DataGridColumn column in grdMechanism.Columns)
              {
                    if (column.Header.Equals("Eventos") || column.Header.Equals("Totales"))
                    {
                        column.IsReadOnly = false;            
                    }
              }
         }
    }
}
