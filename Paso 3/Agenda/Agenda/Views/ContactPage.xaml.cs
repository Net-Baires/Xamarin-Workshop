using Agenda.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Agenda
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactViewModel Contact
        {
            get { return (ContactViewModel)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }
        public static readonly BindableProperty ContactProperty =
            BindableProperty.Create(nameof(Contact), typeof(ContactViewModel), typeof(ContactPage), null);

        public ContactPage()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Contact))
                BindingContext = Contact;
        }
    }
}
