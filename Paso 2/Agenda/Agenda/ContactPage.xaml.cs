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
    public partial class ContactPage : ContentPage
    {
        public ContactViewModel Model { get; set; }

        public ContactPage(ContactViewModel model)
        {
            InitializeComponent();

            Model = model;

            Name.Text = Model.Name;
            LastName.Text = Model.LastName;
            Mail.Text = Model.Mail;
        }
    }
}
