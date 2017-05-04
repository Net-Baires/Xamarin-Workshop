using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.Custom_EventArgs
{
    public class NavigationEventArgs : EventArgs
    {
        readonly Page _pageToNavigate;

        public NavigationEventArgs()
        {
        }

        public NavigationEventArgs(Page pageToNavigate)
        {
            pageToNavigate = _pageToNavigate;
        }

        public Page PageToNavigate => _pageToNavigate;
    }
}
