using Microsoft.Maui.Controls;

namespace tantofaz
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnResposta1Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MortePage());
        }

        private async void OnResposta2Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ThirdPage());
        }
    }
}
