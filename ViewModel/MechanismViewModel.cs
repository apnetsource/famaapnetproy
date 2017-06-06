using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
using FAMA.AP.DataLayer;


namespace FAMA.AP.ViewModel
{
    public class MechanismViewModel : ViewModelBase
    {
        private Mechanism mechanism;
        private ObservableCollection<Mechanism> mechanisms;

        public Mechanism Mechanism
        {
            get
            {
                return mechanism;
            }
            set
            {
                mechanism = value;
                NotifyPropertyChanged("Mechanism");
            }
        }

        public ObservableCollection<Mechanism> Mechanisms
        {
            get
            {
                return mechanisms;
            }
            set
            {
                mechanisms = value;
                NotifyPropertyChanged("Mechanisms");
            }
        }

        private void Execute(object parameter)
        {
            int index = Mechanisms.IndexOf(parameter as Mechanism);
            if (index > -1 && index < Mechanisms.Count)
            {
                DbMechanism au = new DbMechanism();
            }
        }

        public MechanismViewModel()
        {
            Mechanism = new Mechanism();
            DbMechanism me = new DbMechanism();
            List<Mechanism> mechanismLst = me.FindAllMechanismBySectionAndEvent();

            Mechanisms = new ObservableCollection<Mechanism>();
            foreach (var item in mechanismLst)
            {
                Mechanisms.Add(item);
            }

            Mechanisms.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Mechanisms_CollectionChanged);
        }

        void Mechanisms_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Mechanisms");
        }
    }
}
