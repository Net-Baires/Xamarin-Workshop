using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModels
{
    public class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            SaveCommand = new Command(OnSave);
        }

        string _initial;
        string _name;
        string _lastName;
        string _mail;
        ICommand _saveCommand;

        public string Initial
        {
            protected set { if (_initial != value) { _initial = value; OnPropertyChanged(nameof(Initial)); } }
            get { return _initial; }
        }
        public string Name
        {
            protected set { if (_name != value) { _name = value; OnPropertyChanged(nameof(Name)); } }
            get { return _name; }
        }
        public string LastName
        {
            protected set { if (_lastName != value) { _lastName = value; OnPropertyChanged(nameof(LastName)); } }
            get { return _lastName; }
        }
        public string Mail
        {
            protected set { if (_mail != value) { _mail = value; OnPropertyChanged(nameof(Mail)); } }
            get { return _mail; }
        }
        public ICommand SaveCommand
        {
            protected set { if (_saveCommand != value) { _saveCommand = value; OnPropertyChanged(nameof(SaveCommand)); } }
            get { return _saveCommand; }
        }

        void OnSave()
        {
            OnNavigationRequested();
        }

        public event EventHandler<Agenda.Custom_EventArgs.NavigationEventArgs> NavigationRequested;
        void OnNavigationRequested()
        {
            NavigationRequested?.Invoke(null, new Agenda.Custom_EventArgs.NavigationEventArgs());
        }
    }
}
