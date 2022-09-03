using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace AppNamoro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SIM());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NAO());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }
}
