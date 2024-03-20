using Microsoft.Maui.Controls;

namespace tantofaz
{
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private void OnBotao1Clicked(object sender, EventArgs e)
        {
         Navigation.PushAsync(new ContinuaPage());
        }


        private async void OnBotao2Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new MortePage());
        }

    }
}
