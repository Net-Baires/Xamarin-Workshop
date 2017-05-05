using Agenda.Resources;
using Agenda.ViewModels;
using Xamarin.Forms;

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