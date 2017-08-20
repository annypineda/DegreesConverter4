using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DegreesConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DegreesEntry.Text))
            {
                DisplayAlert("Error", "You must enter a value", "Accept");
                return;
            }
#pragma warning disable IDE0018 // Inline variable declaration
            decimal degrees = 0;
#pragma warning restore IDE0018 // Inline variable declaration
            if (!decimal.TryParse(DegreesEntry.Text, out degrees))
            {
                DisplayAlert("Error", "You must enter a numeric value", "Accept");
                return;
            }
            var Farenheit = 32 + ((9 * degrees) / 5);
            var Celsius = (degrees - 32) * 5 / 9;

            FarenheitEntry.Text = string.Format("°{0:N2}", Farenheit);
            CelsiusEntry.Text = string.Format("°{0:N2}", Celsius);


        }
    }
}
