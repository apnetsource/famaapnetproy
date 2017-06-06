using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FAMA.AP.DataLayer;
using FAMA.AP.Model;

namespace FAMA.AP.ViewModel
{
    public class ProcessValueViewModel : ViewModelBase
    {
        private ProcessValue processValue;
        private ObservableCollection<ProcessValue> processValues;

        public ProcessValue ProcessValue
        {
            get
            {
                return processValue;
            }
            set
            {
                processValue = value;
                NotifyPropertyChanged("ProcessValue");
            }
        }

        public ObservableCollection<ProcessValue> ProcessValues
        {
            get
            {
                return processValues;
            }
            set
            {
                processValues = value;
                NotifyPropertyChanged("ProcessValues");
            }
        }

        private void Execute(object parameter)
        {
            int index = processValues.IndexOf(parameter as ProcessValue);
            if (index > -1 && index < processValues.Count)
            {
                DbProcessValue au = new DbProcessValue();
            }
        }

        public ProcessValueViewModel()
        {

            ProcessValue = new ProcessValue();
            DbProcessValue pv = new DbProcessValue();
            List<ProcessValue> processLst = pv.FindAllMechanismBySectionAndEvent();

            ProcessValues = new ObservableCollection<ProcessValue>();
            foreach (var item in processLst)
            {
                ProcessValues.Add(item);
            }

            ProcessValues.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(ProcessValues_CollectionChanged);
        }

        void ProcessValues_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("ProcessValues");
        }
    }
}

