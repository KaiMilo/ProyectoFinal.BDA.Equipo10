using ProyectoFinal.BDA.Equipo10.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ProyectoFinal.BDA.Equipo10.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeleccionDeGenero : ContentPage
    {
        public SeleccionDeGenero()
        {
            InitializeComponent();
        }

        private async void Actrices_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Actrices());
        }


        private async void Actores_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Actores());
        }
    }
}