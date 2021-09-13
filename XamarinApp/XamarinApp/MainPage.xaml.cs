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
        List<Product> products = new List<Product>();

        public MainPage()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Product p = new Product(
                    new Random().Next(0, 10000).ToString(), 
                    new Random().Next(0, 10000).ToString(), 
                    new Random().Next(0, 10000).ToString(), 
                    "https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/picker/images/picker-selection-large.png#lightbox");

                products.Add(p);
            }
        }

        private void Item_Selected(object sender, SelectionChangedEventArgs e)
        {
            Product product = e.CurrentSelection.First() as Product;
            Navigation.PushAsync(new Course(product));
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = products;
        }
    }
}
