using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNamoro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NAO : ContentPage
    {
        public NAO()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}