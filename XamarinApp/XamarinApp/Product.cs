using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApp
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image_Title { get; set; }
        public string Image { get; set; }
        public Uri Image_Uri { get { return string.IsNullOrEmpty(Image) ? null : new Uri(Image); } }
        
        public Product()
        {
            Name = "Empty";
            Description = "Empty";
            Image_Title = "None";
            Image = "https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/picker/images/picker-selection-large.png#lightbox";
        }

        public Product(string name, string description, string image_title, string image)
        {
            Name = name;
            Description = description;
            Image_Title = image_title;
            Image = image;
        }
    }
}
