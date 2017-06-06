using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
using System.Collections.Generic;

namespace FAMA.AP.ViewModel
{
    public class SectionsViewModel : ViewModelBase
    {
        private Sections _section;
        private ObservableCollection<Sections> _sections;
        private ICommand _SelectCommand;

        public Sections Section
        {
            get
            {
                return _section;
            }
            set
            {
                _section = value;
                NotifyPropertyChanged("Section");
            }
        }

        public ObservableCollection<Sections> Sections
        {
            get
            {
                return _sections;
            }
            set
            {
                _sections = value;
                NotifyPropertyChanged("Sections");
            }
        }

        public ICommand SelectCommand 
        {
            get
            {

                if (_SelectCommand == null)
                {
                    _SelectCommand = new RelayCommand(param => this.Select(), null);

                }
                return _SelectCommand;
            }
        }

        public SectionsViewModel()
        {
            Section = new Sections();
            FAMA.AP.DataLayer.DbSections dataSections = new DataLayer.DbSections();
            // List<FAMA.AP.Model.Sections> sectionList = dataSections.SelectAll();

            Sections = new ObservableCollection<Sections>();
        }

        private void Select()
        {
            FAMA.AP.DataLayer.DbSections dbSections = new FAMA.AP.DataLayer.DbSections();
            FAMA.AP.Model.Sections section = dbSections.SelectSectionById(Section.idActiveSections);

            Sections = new ObservableCollection<Sections>();
        }
    }
}
