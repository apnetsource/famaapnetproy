using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Data;
using FAMA.AP.Model;
using System.ComponentModel;

namespace FAMA.AP.ViewModel
{
    public class MecanismosViewModel : ViewModelBase
    {
        private Mecanismos _Mecanismos;
        private Maquina _Maquina;
        private ObservableCollection<Mecanismos> _Mecanismoss;

        public event PropertyChangedEventHandler PropertyChanged;
        public Maquina SelectedcbDefaultLocationListItem = new Maquina { vcName = "---Seleccionar---", idMachineType = 0 };

        public ObservableCollection<Maquina> MaquinaList { get; set; }

        private int _selectedMaquinaID;

        private ICommand _AddCommand;
        private ICommand _RemoveCommand;
        private ICommand _EditCommand;


        public int SelectedMaquinaID
        {
            get { return _selectedMaquinaID; }
            set
            {
                if (_selectedMaquinaID != value)
                {
                    _selectedMaquinaID = value;

                    RaisePropertyChanged("SelectedMaquinaID");
                }
            }
        }

        public Mecanismos Mecanismos
        {
            get
            {
                return _Mecanismos;
            }
            set
            {
                _Mecanismos = value;
                NotifyPropertyChanged("Mecanismos");
            }
        }

        public Maquina Maquina
        {
            get
            {
                return _Maquina;
            }
            set
            {
                _Maquina = value;
                NotifyPropertyChanged("Maquina");
            }
        }

        public ObservableCollection<Mecanismos> Mecanismoss
        {
            get
            {
                return _Mecanismoss;
            }
            set
            {
                _Mecanismoss = value;
                NotifyPropertyChanged("Mecanismoss");
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (_AddCommand == null)
                {
                    _AddCommand = new RelayCommand(param => this.Add(), null);
                }
                return _AddCommand;
            }
        }

        public ICommand RemoveCommand
        {
            get
            {
                if (_RemoveCommand == null)
                {
                    _RemoveCommand = new DelegateCommand(CanExecute, Execute);
                }
                return _RemoveCommand;
            }
        }

        public ICommand EditCommand
        {
            get
            {
                if (_EditCommand == null)
                {
                    _EditCommand = new DelegateCommand(CanEditExecute, ExecuteEdit);
                }
                return _EditCommand;
            }
        }


        private void Execute(object parameter)
        {
            int index = Mecanismoss.IndexOf(parameter as Mecanismos);
            if (index > -1 && index < Mecanismoss.Count)
            {
                FAMA.AP.DataLayer.DbMecanismos au = new FAMA.AP.DataLayer.DbMecanismos();
                au.DeleteData(Mecanismoss[index]);
                Mecanismoss.RemoveAt(index);
            }
        }

        private bool CanEditExecute(object parameter)
        {
            return true;
        }

        private void ExecuteEdit(object parameter)
        {
            int index = Mecanismoss.IndexOf(parameter as Mecanismos);
            if (index > -1 && index < Mecanismoss.Count)
            {
                Mecanismos = new Mecanismos();
                Mecanismos = Mecanismoss[index];

            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

        public MecanismosViewModel()
        {
            Mecanismos = new Mecanismos();
            Maquina = new Maquina();
            FAMA.AP.DataLayer.DbMecanismos au = new FAMA.AP.DataLayer.DbMecanismos();
            FAMA.AP.DataLayer.DbMaquina aum = new FAMA.AP.DataLayer.DbMaquina();
            List<FAMA.AP.Model.Mecanismos> MecanismosLst = au.Selectalldata();
            List<FAMA.AP.Model.Maquina> MaquinaLst = aum.Selectalldata();

            Mecanismoss = new ObservableCollection<Mecanismos>();
            foreach (var item in MecanismosLst)
            {
                Mecanismoss.Add(item);
            }

            Mecanismoss.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Mecanismos_CollectionChanged);

            MaquinaList = new ObservableCollection<Maquina>();
            foreach (var item in MaquinaLst)
            {
                MaquinaList.Add(item);
            }
            //MaquinaList.Add(new Maquina() { MaquinaList.idMachineType, MaquinaList.vcName });
            //MaquinaList.Add(new Maquina() { idMachineType = 2, vcName = "There" });

            MaquinaList.Insert(0, SelectedcbDefaultLocationListItem);

            SelectedMaquinaID = SelectedcbDefaultLocationListItem.idMachineType;
        }

        private Process _SelectedProceso;
        public Process SelectedProceso
        {
            get
            {
                return _SelectedProceso;
            }
            set
            {
                _SelectedProceso = value;
                OnPropertyChanged("SelectedProceso");
                //this.Cities = _SelectedProceso.Cities;
                OnPropertyChanged("Cities");
            }
        }

        #region INotifyPropertyChanged Members
        //public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            //PropertyChangedEventHandler handler = PropertyChanged;
            //if (handler != null)
            //    handler(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        public void ResetSelectedItem()
        {
            SelectedMaquinaID = SelectedcbDefaultLocationListItem.idMachineType;
        }

        void Mecanismos_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Mecanismoss");
        }

        private void Add()
        {
            FAMA.AP.DataLayer.DbMecanismos au = new FAMA.AP.DataLayer.DbMecanismos();
            au.InsertData(Mecanismos);


            List<FAMA.AP.Model.Mecanismos> MecanismosLst = au.Selectalldata();

            Mecanismoss = new ObservableCollection<Mecanismos>();
            foreach (var item in MecanismosLst)
            {
                Mecanismoss.Add(item);
            }
        }


        public CollectionView Queries { get; private set; }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
