using System.Windows.Input;
using Xamarin.Forms;

namespace Agenda.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        public LogInViewModel()
        {
            _logInCommand = new Command(LogIn);
        }

        ICommand _logInCommand;
        public string _userName;
        public string _password;

        public ICommand LogInCommand
        {
            get { return _logInCommand; }
            protected set { if (_logInCommand == value) return; _logInCommand = value; OnPropertyChanged(nameof(LogInCommand)); }
        }

        public string UserName
        {
            protected set { if (_userName != value) { _userName = value; OnPropertyChanged(nameof(UserName)); } }
            get { return _userName; }
        }

        public string Password
        {
            protected set { if (_password != value) { _password = value; OnPropertyChanged(nameof(Password)); } }
            get { return _password; }
        }

        public void LogIn()
        {
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}