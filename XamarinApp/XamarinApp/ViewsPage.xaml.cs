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
    public partial class ViewsPage : TabbedPage
    {
        public ViewsPage()
        {
            InitializeComponent();
        }

        private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = slider1.Value.ToString();
        }

        private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label2.Text = stepper1.Value.ToString();
        }

        private void switch1_Toggled(object sender, ToggledEventArgs e)
        {
            checkbox1.IsVisible = e.Value;
        }

        private void button2_Clicked(object sender, EventArgs e)
        {
            if(entry1.Text.Length > 0 && entry2.Text.Length > 0) { label3.Text = Calculate().ToString(); } 
            else { }
        }

        private int Calculate()
        {
            int int1 = 0;
            int int2 = 0;
            
            switch (picker1.SelectedIndex)
            {
                case 0: //+
                    if (int.TryParse(entry1.Text, out int1) && int.TryParse(entry2.Text, out int2)) { return int1 + int2; }
                    else { return 0; }

                case 1: //-
                    if (int.TryParse(entry1.Text, out int1) && int.TryParse(entry2.Text, out int2)) { return int1 - int2; }
                    else { return 0; }

                case 2: // /
                    if (int.TryParse(entry1.Text, out int1) && int.TryParse(entry2.Text, out int2)) { return int1 / int2; }
                    else { return 0; }

                case 3: //x
                    if (int.TryParse(entry1.Text, out int1) && int.TryParse(entry2.Text, out int2)) { return int1 * int2; }
                    else { return 0; }

                default:
                    return 0;
            }
        }
    }
}