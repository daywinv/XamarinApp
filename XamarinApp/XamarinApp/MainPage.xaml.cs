using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void kurkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KurkPage());
        }

        private void viewsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ViewsPage());
        }

        private void courseButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Course());
        }
    }
}
