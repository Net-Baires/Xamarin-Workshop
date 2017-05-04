using Agenda.Model;
using AutoMapper;
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
            set { if (_logInCommand == value) return; _logInCommand = value; OnPropertyChanged(nameof(LogInCommand)); }
        }

        public string UserName
        {
            set { if (_userName != value) { _userName = value; OnPropertyChanged(nameof(UserName)); } }
            get { return _userName; }
        }

        public string Password
        {
            set { if (_password != value) { _password = value; OnPropertyChanged(nameof(Password)); } }
            get { return _password; }
        }

        public void LogIn()
        {
            User model = new User();

            Mapper.CreateMap<LogInViewModel, User>();
            Mapper.Map<LogInViewModel, User>(this, model);

            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}