
using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
using System.Collections.Generic;
using System.Windows.Data;
using System;

namespace FAMA.AP.ViewModel
{
    public class CeisViewModel: ViewModelBase
    {
        private Ceis _ceis;
        private ObservableCollection<Ceis> _ceiss;
        IList<FAMA.AP.Model.ProcessType> processTypeList = new List<FAMA.AP.Model.ProcessType>();

        private ICommand _AddCommand;
        private ICommand _RemoveCommand;
        private ICommand _EditCommand;
        public Ceis Ceis
        {
            get
            {
                return _ceis;
            }
            set
            {
                _ceis = value;
                NotifyPropertyChanged("Ceis");
            }
        }

        public ObservableCollection<Ceis> Ceiss
        {
            get
            {
                return _ceiss;
            }
            set
            {
                _ceiss = value;
                NotifyPropertyChanged("Ceis");
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
                    _RemoveCommand = new DelegateCommand(CanExecute, Execute);
                
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
            int index = Ceiss.IndexOf(parameter as Ceis);
            if (index > -1 && index < Ceiss.Count)
            {
                FAMA.AP.DataLayer.DbCeis Conexion = new FAMA.AP.DataLayer.DbCeis();
                Conexion.DeleteData(Ceiss[index]);
                Ceiss.RemoveAt(index);
            }
        }

        private bool CanEditExecute(object parameter)
        {
            return true;
        }

        private void ExecuteEdit(object parameter)
        {
            int index = Ceiss.IndexOf(parameter as Ceis);
            if (index > -1 && index < Ceiss.Count)
            {
                Ceis = new Ceis();
                Ceis = Ceiss[index];

                //int i = 0;
                //foreach (var item in availableQueries)
                //{
                //    if (item.idProfile == User.IdProfile)
                //    {
                //        Queries.MoveCurrentTo(availableQueries[i]);
                //        break;
                //    }
                //    i++;
                //}



                //FAMA.AP.Model.Profile currentQuery = (FAMA.AP.Model.Profile)Queries.CurrentItem;
                //currentQuery.idProfile = User.IdProfile;
                //currentQuery.ProfileName = User.ProfileName;

            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

        public CeisViewModel()
        {
            Ceis = new Ceis();
            FAMA.AP.DataLayer.DbCeis Conexion = new FAMA.AP.DataLayer.DbCeis();
            Ceis = Conexion.Selectalldata();     
            Ceiss = new ObservableCollection<Ceis>();
            

            FAMA.AP.DataLayer.DbProcessType CxnProcessType = new FAMA.AP.DataLayer.DbProcessType();
            processTypeList = CxnProcessType.Selectalldata();

            qryProcessType = new CollectionView(processTypeList);
            qryProcessType.MoveCurrentTo(processTypeList[0]);
            qryProcessType.CurrentChanged += new EventHandler(queryProcessType_CurrentChanged);

            Ceiss.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Ceiss_CollectionChanged);
        }

        void queryProcessType_CurrentChanged(object sender, EventArgs e)
        {
            FAMA.AP.Model.ProcessType currentProcessType = (FAMA.AP.Model.ProcessType)qryProcessType.CurrentItem;
            Ceis.CeisType = currentProcessType.IdProcessType;
            Ceis.CeisTypeDesc = currentProcessType.Name;
        }

        void Ceiss_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Ceiss");
        }

        private void Add()
        {
            FAMA.AP.DataLayer.DbCeis Conexion = new FAMA.AP.DataLayer.DbCeis();
            Conexion.InsertData(Ceis);            
        }

        public CollectionView qryProcessType { get; private set; }


    }

}
