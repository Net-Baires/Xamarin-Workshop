using Agenda.Resources.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.Resources
{
    static class CommonResources
    {
        public static ResourceDictionary Resources { get; set; }

        static CommonResources()
        {
            Resources = new ResourceDictionary();

            SetAppResources();

            SetConverters();
        }

        static void SetAppResources()
        {
            Style label = new Style(typeof(Label))
            {
                Setters = {
                    new Setter { Property = Label.TextColorProperty, Value = Color.Black },
                    new Setter { Property = Label.FontSizeProperty, Value = 16 }
                }
            };

            Resources.Add(label);
        }

        static void SetConverters()
        {
            Resources.Add("stringtoupper", new StringToUpperConverter());
            Resources.Add("getinitial", new GetInitialConverter());
        }
    }
}
