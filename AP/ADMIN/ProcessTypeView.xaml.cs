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
using FAMA.AP.ViewModel;

namespace FAMA.AP.Desktop.View.ADMIN
{
    /// <summary>
    /// Lógica de interacción para ProcessTypeView.xaml
    /// </summary>
    /// 

    
    
    public partial class ProcessTypeView : UserControl
    {
        public ProcessTypeView()
        {
            InitializeComponent();
        }

		private void btn_edit_Click(object sender, RoutedEventArgs e)
		{
			//ProcessTypeView idProcesType = (ProcessTypeView)GridProcess.SelectedItem;
			btn_cancel.Visibility = Visibility.Visible;
			btn_save.Visibility = Visibility.Visible;
			txtName.Visibility = Visibility.Visible;
			txtDescripcion.Visibility = Visibility.Visible;

			if (GridProcess.SelectedItems.Count > 0)
			{
				for (int i = 0; i < GridProcess.SelectedItems.Count; i++)
				{
					//System.Data.DataRowView selectedFile = (System.Data.DataRowView)GridProcess.SelectedItems[i];
					FAMA.AP.Model.ProcessType selectedid = (FAMA.AP.Model.ProcessType)GridProcess.SelectedItems[i];
					int idProcesType = (selectedid.IdProcessType);
					string Nombre = Convert.ToString(selectedid.Name);
					string Descripcion = Convert.ToString(selectedid.Description);
					txtName.Text = Nombre;
					txtDescripcion.Text = Descripcion;
				}
			}
            //FAMA.AP.ViewModel.ProcessTypeViewModel
            //ProcessTypeViewModel
            
            int index = GridProcess.SelectedIndex;
			int id = GridProcess.SelectedIndex;

			/*int IdServ = GridProcess.Columns[1].GetCellContent(dataGridRow).TextInput;


			if (dgUserEnroll.SelectedItem != null)
			{
				var data = (User)dgUserEnroll.SelectedItem;
				var userID = data.UserId;
			}*/
			txtName.IsEnabled = true;
			txtDescripcion.IsEnabled = true;

		}

		private void btn_add_Click(object sender, RoutedEventArgs e)
		{
			txtName.Text = "";
			txtDescripcion.Text = "";
			txtName.IsEnabled = true;
			txtDescripcion.IsEnabled = true;
			btn_cancel.Visibility = Visibility.Visible;
			btn_save.Visibility = Visibility.Visible;
			txtName.Visibility = Visibility.Visible;
			txtDescripcion.Visibility = Visibility.Visible;

			/*if (GridProcess.SelectedItems.Count > 0)
			{
				for (int i = 0; i < GridProcess.SelectedItems.Count; i++)
				{
					FAMA.AP.Model.ProcessType selectedid = (FAMA.AP.Model.ProcessType)GridProcess.SelectedItems[i];
					idProcesType = (selectedid.IdProcessType);
				}
			}

			//int index = GridProcess.SelectedIndex;
			//int id = GridProcess.SelectedIndex;

			string Nombre = txtName.Text;
			string Descripcion = txtDescripcion.Text;

			ViewModel.ProcessTypeViewModel objnewpt = new ProcessTypeViewModel();
			Model.ProcessType objprocess = new Model.ProcessType();
			objprocess.IdProcessType = idProcesType;
			objprocess.Name = Nombre;
			objprocess.Description = Descripcion;
			objprocess.active = true;

			FAMA.AP.DataLayer.DbProcessType au = new FAMA.AP.DataLayer.DbProcessType();
			au.InsertData(objprocess);
			GridProcess.ItemsSource = au.Selectalldata();
			GridProcess.Items.Refresh();

			txtName.Text = "";
			txtDescripcion.Text = "";
			txtName.IsEnabled = false;
			txtDescripcion.IsEnabled = false;
			btn_cancel.Visibility = Visibility.Hidden;
			btn_save.Visibility = Visibility.Hidden;*/
		}

		private void btn_cancel_Click(object sender, RoutedEventArgs e)
		{
			txtName.Text = "";
			txtDescripcion.Text = "";
			txtName.IsEnabled = false;
			txtDescripcion.IsEnabled = false;
			btn_cancel.Visibility = Visibility.Hidden;
			btn_save.Visibility = Visibility.Hidden;
			txtName.Visibility = Visibility.Hidden;
			txtDescripcion.Visibility = Visibility.Hidden;

		}

		private void btn_save_Click(object sender, RoutedEventArgs e)
		{
			int idProcesType = 0;
			if (GridProcess.SelectedItems.Count > 0)
			{
				for (int i = 0; i < GridProcess.SelectedItems.Count; i++)
				{
					FAMA.AP.Model.ProcessType selectedid = (FAMA.AP.Model.ProcessType)GridProcess.SelectedItems[i];
					idProcesType = (selectedid.IdProcessType);
				}
			}
			
			//int index = GridProcess.SelectedIndex;
			//int id = GridProcess.SelectedIndex;

			string Nombre = txtName.Text;
			string Descripcion = txtDescripcion.Text;

			ViewModel.ProcessTypeViewModel objnewpt = new ProcessTypeViewModel();
			Model.ProcessType objprocess = new Model.ProcessType();
			objprocess.IdProcessType = idProcesType;
			objprocess.Name = Nombre;
			objprocess.Description = Descripcion;
			objprocess.active = true;

			FAMA.AP.DataLayer.DbProcessType au = new FAMA.AP.DataLayer.DbProcessType();
			if (idProcesType > 0)
			{
				au.UpdateData(objprocess);
			}
			else
			{
				au.InsertData(objprocess);
			}
			GridProcess.ItemsSource = au.Selectalldata(); 
			GridProcess.Items.Refresh();
			
			txtName.Text = "";
			txtDescripcion.Text = "";
			txtName.IsEnabled = false;
			txtDescripcion.IsEnabled = false;
			btn_cancel.Visibility = Visibility.Hidden;
			btn_save.Visibility = Visibility.Hidden;
			txtName.Visibility = Visibility.Hidden;
			txtDescripcion.Visibility = Visibility.Hidden;

		}
	}
}
