using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xapp
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
			InitializeComponent ();
        }
        async void OnbtnpageClickme(object sender, EventArgs arg)
        {
            Button Button = (Button)sender;
            await DisplayAlert("Loged",
        "Las credenciales se introdujeron correctamente", "Siguiente");
            await Navigation.PushModalAsync(new Page2());
        }

    }
}
;