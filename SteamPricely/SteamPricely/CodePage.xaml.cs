using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SteamPricely
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodePage : ContentPage
    {
        public CodePage()
        {
            InitializeComponent();
        }

        private void CheckButton_Clicked(object sender, EventArgs e)
        {
            var key = Key.Text;

        }
    }
}