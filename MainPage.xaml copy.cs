using Microsoft.Maui.Controls;

namespace tantofaz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }

        private async void OnSobreAppClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobreAppPage());
        }
    }
}
