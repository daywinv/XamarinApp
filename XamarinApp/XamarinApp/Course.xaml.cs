using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Course : ContentPage
    {
        public Course()
        {
            InitializeComponent();
        }
        public Course(Product product)
        {
            InitializeComponent();
            BindingContext = product;
        }

        private void orderBtn_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}