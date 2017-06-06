using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Data;
using FAMA.AP.Model;

namespace FAMA.AP.ViewModel
{
    public class ProcessTypeViewModel: ViewModelBase
    {

        private ProcessType _ProcessType;
        private ObservableCollection<ProcessType> _ProcessTypes;

        private ICommand _AddCommand;
        private ICommand _RemoveCommand;
        private ICommand _EditCommand;

        public ProcessType ProcessType
        {
            get
            {
                return _ProcessType;
            }
            set
            {
                _ProcessType = value;
                NotifyPropertyChanged("ProcessType");
            }
        }

        public ObservableCollection<ProcessType> ProcessTypes
        {
            get
            {
                return _ProcessTypes;
            }
            set
            {
                _ProcessTypes = value;
                NotifyPropertyChanged("ProcessTypes");
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
            int index = ProcessTypes.IndexOf(parameter as ProcessType);
            if (index > -1 && index < ProcessTypes.Count)
            {
                FAMA.AP.DataLayer.DbProcessType au = new FAMA.AP.DataLayer.DbProcessType();
                au.DeleteData(ProcessTypes[index]);
                ProcessTypes.RemoveAt(index);
            }
        }

        private bool CanEditExecute(object parameter)
        {
            return true;
        }

        private void ExecuteEdit(object parameter)
        {
            int index = ProcessTypes.IndexOf(parameter as ProcessType);
            if (index > -1 && index < ProcessTypes.Count)
            {
                ProcessType = new ProcessType();
                ProcessType = ProcessTypes[index];

            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

        public ProcessTypeViewModel()
        {
            ProcessType = new ProcessType();
            FAMA.AP.DataLayer.DbProcessType au = new FAMA.AP.DataLayer.DbProcessType();
            List<FAMA.AP.Model.ProcessType> ProcessTypesLst = au.Selectalldata();

            ProcessTypes = new ObservableCollection<ProcessType>();
            foreach (var item in ProcessTypesLst)
            {
                ProcessTypes.Add(item);
            }

            ProcessTypes.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(ProcessType_CollectionChanged);
        }

        void ProcessType_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("ProcessTypes");
        }

        private void Add()
        {
            FAMA.AP.DataLayer.DbProcessType au = new FAMA.AP.DataLayer.DbProcessType();
            au.InsertData(ProcessType);


            List<FAMA.AP.Model.ProcessType> ProcessTypesLst = au.Selectalldata();

            ProcessTypes = new ObservableCollection<ProcessType>();
            foreach (var item in ProcessTypesLst)
            {
                ProcessTypes.Add(item);
            }
        }


        public CollectionView Queries { get; private set; }


    }
}
