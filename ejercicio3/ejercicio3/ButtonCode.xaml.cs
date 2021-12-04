using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ejercicio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonCode : ContentPage
    {
        public ButtonCode()
        {
            InitializeComponent();

            Title = "code button click";
            Label label = new Label();
            {
               // Text = "click the button below",
               // FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label)),
              //  VerticalOptions = LayoutOptions.CenterAndExpand,
               // HorizontalOptions = LayoutOptions.Center

            }
        }
    }
}