
using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
using System.Collections.Generic;
using System.Windows.Data;
using System;

namespace FAMA.AP.ViewModel
{
    public class UserViewModel: ViewModelBase
    {
        private User _user;
        private ObservableCollection<User> _users;
        IList<FAMA.AP.Model.Profile> availableQueries = new List<FAMA.AP.Model.Profile>();

        private ICommand _AddCommand;
        private ICommand _RemoveCommand;
        private ICommand _EditCommand;
        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }

        public ObservableCollection<User> Users
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
                NotifyPropertyChanged("Users");
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
                    //_RemoveCommand = new RelayCommand(param => this.Remove(), null);
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
            int index = Users.IndexOf(parameter as User);
            if (index > -1 && index < Users.Count)
            {
                FAMA.AP.DataLayer.DbUser au = new FAMA.AP.DataLayer.DbUser();
                au.DeleteData(Users[index]);
                Users.RemoveAt(index);
            }
        }

        private bool CanEditExecute(object parameter)
        {
            return true;
        }

        private void ExecuteEdit(object parameter)
        {
            int index = Users.IndexOf(parameter as User);
            if (index > -1 && index < Users.Count)
            {
                User = new User();
                User = Users[index];

                int i = 0;
                foreach (var item in availableQueries)
                {
                    if (item.idProfile == User.IdProfile)
                    {
                        Queries.MoveCurrentTo(availableQueries[i]);
                        break;
                    }
                    i++;
                }



                FAMA.AP.Model.Profile currentQuery = (FAMA.AP.Model.Profile)Queries.CurrentItem;
                currentQuery.idProfile = User.IdProfile;
                currentQuery.ProfileName = User.ProfileName;

            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }

        public UserViewModel()
        {
            User = new User();
            FAMA.AP.DataLayer.DbUser au = new FAMA.AP.DataLayer.DbUser();
            List<FAMA.AP.Model.User> userlst = au.Selectalldata();

            Users = new ObservableCollection<User>();
            foreach (var item in userlst)
            {
                Users.Add(item);
            }


            availableQueries = FAMA.AP.DataLayer.DbProfile.Selectalldata();

            Queries = new CollectionView(availableQueries);
            Queries.MoveCurrentTo(availableQueries[0]);
            Queries.CurrentChanged += new EventHandler(queries_CurrentChanged);
            Users.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Users_CollectionChanged);
        }

        void queries_CurrentChanged(object sender, EventArgs e)
        {
            FAMA.AP.Model.Profile currentQuery = (FAMA.AP.Model.Profile)Queries.CurrentItem;
            User.IdProfile = currentQuery.idProfile;
            User.ProfileName = currentQuery.ProfileName;
        }

        void Users_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Users");
        }

        private void Add()
        {
            FAMA.AP.DataLayer.DbUser au = new FAMA.AP.DataLayer.DbUser();
            au.InsertData(User);


            List<FAMA.AP.Model.User> userlst = au.Selectalldata();

            Users = new ObservableCollection<User>();
            foreach (var item in userlst)
            {
                Users.Add(item);
            }
        }

        public CollectionView Queries { get; private set; }


    }

}
