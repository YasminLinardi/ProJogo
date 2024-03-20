using Microsoft.Maui.Controls;
using System;

namespace tantofaz
{
    public partial class MortePage : ContentPage
    {
        public MortePage()
        {
            InitializeComponent();
        }

        private async void OnRecomecarClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync(); 
        }
    }
}
