using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Agenda.ViewModels;
using Agenda.Custom_EventArgs;
using Agenda.Resources;

namespace Agenda
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            Resources = CommonResources.Resources;

            InitializeComponent();

            Title = "AGENDA";

            ViewModel = new MainViewModel();

            BindingContext = ViewModel;
        }

        void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;

            ViewModel?.ListViewItemSelectedCommand?.Execute(e);

            listView.SelectedItem = null;
        }
    }
}