using Microsoft.Maui.Controls;

namespace tantofaz
{
    public partial class ContinuaPage : ContentPage
    {
        public ContinuaPage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            
             await Navigation.PopToRootAsync(); 
        }
    }
}
