using Microsoft.Maui.Controls;

namespace tantofaz
{
    public partial class SobreAppPage : ContentPage
    {
        public SobreAppPage()
        {
            InitializeComponent();
        }

        private async void OnIniciarClicked(object sender, EventArgs e)
        {
             await Navigation.PopToRootAsync(); 
        }
}
}
