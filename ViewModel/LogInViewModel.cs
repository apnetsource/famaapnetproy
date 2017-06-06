using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;

namespace FAMA.AP.ViewModel
{
    public class LogInViewModel : ViewModelBase
    {
        private User _user;
        private ObservableCollection<User> _users;
        private ICommand _CheckCommand;

        public LogInViewModel()
        {
            User = new User();

            Users = new ObservableCollection<User>();
            Users.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(Users_CollectionChanged);

        }

        void Users_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Users");
        }

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

        public ICommand CheckCommand
        {
            get
            {
                if (_CheckCommand == null)
                {
                    _CheckCommand = new DelegateCommand(CanExecute, Execute);
                }
                return _CheckCommand;
            }
        }
        private void Execute(object parameter)
        {
            FAMA.AP.DataLayer.DbUser au = new FAMA.AP.DataLayer.DbUser();
            //if (au.CheckUser(User.UserName, User.Password) == 1)
                
            //else
            //    throw new System.Exception("User Name or Password are Invalid!");
        }


        private bool CanExecute(object parameter)
        {
            return true;
        }
       
    }
}
