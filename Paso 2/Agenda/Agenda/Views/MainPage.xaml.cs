using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Agenda.ViewModels;
using Agenda.Custom_EventArgs;

namespace Agenda
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Title = "AGENDA";

            ViewModel = new MainViewModel();

            BindingContext = ViewModel;

            ViewModel.NavigationRequested += (s, e) => Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(e.PageToNavigate));
        }
    }
}

//    List<ContactViewModel> contacts = new List<ContactViewModel>();
//    contacts.Add(new ContactViewModel() { Name = "Esteban", LastName = "Yañez", Mail = "eyanez.89@gmail.com" });
//    contacts.Add(new ContactViewModel() { Name = "Germán", LastName = "Küber", Mail = "german.kuber@outlook.com" });

//    Contacts.ItemsSource = contacts;
//    Contacts.ItemTemplate = new DataTemplate(() =>
//    {
//        var name = new Label
//        {
//            VerticalTextAlignment = TextAlignment.Center,
//            HorizontalOptions = LayoutOptions.StartAndExpand
//        };
//        name.SetBinding(Label.TextProperty, "Name");

//        var lastName = new Label
//        {
//            VerticalTextAlignment = TextAlignment.Center,
//            HorizontalOptions = LayoutOptions.StartAndExpand
//        };
//        lastName.SetBinding(Label.TextProperty, "LastName");

//        var mail = new Label
//        {
//            VerticalTextAlignment = TextAlignment.Center,
//            HorizontalOptions = LayoutOptions.StartAndExpand
//        };
//        mail.SetBinding(Label.TextProperty, "Mail");

//        var stackLayout = new StackLayout
//        {
//            Margin = new Thickness(20, 0, 0, 0),
//            Orientation = StackOrientation.Horizontal,
//            HorizontalOptions = LayoutOptions.FillAndExpand,
//            Children = { name, lastName, mail }
//        };

//        return new ViewCell { View = stackLayout };
//    });

//    Contacts.ItemSelected += async (sender, e) =>
//    {
//        ContactViewModel contact = e.SelectedItem as ContactViewModel;

//        await Navigation.PushAsync(new ContactPage(contact));
//    };
//}
