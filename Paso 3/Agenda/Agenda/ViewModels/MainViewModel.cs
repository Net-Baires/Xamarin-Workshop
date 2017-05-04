using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Agenda.Custom_EventArgs;

namespace Agenda.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Contacts = new ObservableCollection<ContactViewModel>();
            Contacts.Add(new ContactViewModel() { Name = "Esteban", LastName = "Yañez", Mail = "eyanez.89@gmail.com" });
            Contacts.Add(new ContactViewModel() { Name = "Germán", LastName = "Küber", Mail = "german.kuber@outlook.com" });
        }

        private ObservableCollection<ContactViewModel> _contacts;
        Command<SelectedItemChangedEventArgs> _listViewItemSelectedCommand;

        public ObservableCollection<ContactViewModel> Contacts
        {
            set { if (_contacts != value) { _contacts = value; OnPropertyChanged(nameof(Contacts)); } }
            get { return _contacts; }
        }

        public Command<SelectedItemChangedEventArgs> ListViewItemSelectedCommand => _listViewItemSelectedCommand ??
        (_listViewItemSelectedCommand = new Command<SelectedItemChangedEventArgs>(ExecuteListViewItemSelectedCommand));

        public event EventHandler<Agenda.Custom_EventArgs.NavigationEventArgs> NavigationRequested;

        void ExecuteListViewItemSelectedCommand(SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ContactViewModel;

            if (item != null)
                OnNavigationRequested(new ContactPage() { Contact = item });
        }

        void OnNavigationRequested(Page pageToNavigate)
        {
            NavigationRequested?.Invoke(null, new Agenda.Custom_EventArgs.NavigationEventArgs(pageToNavigate));
        }
    }
}
