using System.Windows.Input;
using System.Collections.ObjectModel;
using FAMA.AP.Model;
using System.Collections.Generic;
using System.Windows.Data;
using System;


namespace FAMA.AP.ViewModel
{
    public class ClientViewModel : ViewModelBase
    {
        private Client _client;
        private ObservableCollection<Client> _clients;

        private ICommand _AddCommand;
        private ICommand _RemoveCommand;

        public Client Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
                NotifyPropertyChanged("Client");
            }
        }

        public ObservableCollection<Client> Clients
        {
            get
            {
                return _clients;
            }
            set
            {
                _clients = value;
                NotifyPropertyChanged("Clients");
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
                if(_RemoveCommand == null)
                {
                    _RemoveCommand = new RelayCommand(param => this.Remove(), null);
                }
                return _RemoveCommand;
            }
        }

        public ClientViewModel() //Cargar la vista
        {
            Client = new Client();
            FAMA.AP.DataLayer.DbClient dataClient = new FAMA.AP.DataLayer.DbClient();
            Client = dataClient.FindAll();

            Clients = new ObservableCollection<Client>();
            
        }

        void Clients_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Clients");
        }

        private void Add()
        {
            FAMA.AP.DataLayer.DbClient dataClient = new FAMA.AP.DataLayer.DbClient();
            dataClient.InsertOrUpdClient(Client);

            Clients = new ObservableCollection<Client>();
           
        }

        private void Remove()
        {
            Client = new Client();
            FAMA.AP.DataLayer.DbClient dataClient = new FAMA.AP.DataLayer.DbClient();
            Client = dataClient.FindAll();
        }
    }
}
