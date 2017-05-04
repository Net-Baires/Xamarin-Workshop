using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Agenda.CustomRenderer
{
    public class BaseEntry : Entry
    {
        public BaseEntry()
        {
            Completed += Goto;
        }

        public BaseEntry Next { get; set; }

        // Need to overwrite default handler because we cant Invoke otherwise
        public new event EventHandler Completed;

        public const string ReturnKeyPropertyName = "ReturnKeyType";

        public static readonly BindableProperty ReturnTypeProperty = BindableProperty.Create(
                propertyName: ReturnKeyPropertyName,
                returnType: typeof(ReturnType),
                declaringType: typeof(BaseEntry),
                defaultValue: ReturnType.Done);

        private void Goto(object sender, EventArgs e)
        {
            if (sender != null && ((BaseEntry)sender).Next != null)
                ((BaseEntry)sender).Next.Focus();
        }
        public ReturnType ReturnType
        {
            get { return (ReturnType)GetValue(ReturnTypeProperty); }
            set { SetValue(ReturnTypeProperty, value); }
        }

        public void InvokeCompleted()
        {
            if (this.Completed != null)
                this.Completed.Invoke(this, null);
        }
    }

    public enum ReturnType
    {
        Go,
        Next,
        Done,
        Send,
        Search
    }
}
