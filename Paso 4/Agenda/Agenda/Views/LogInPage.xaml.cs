using Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        LogInViewModel ViewModel { get; set; }

        public LogInPage()
        {
            InitializeComponent();

            ViewModel = new LogInViewModel();

            BindingContext = ViewModel;
        }
    }
}
