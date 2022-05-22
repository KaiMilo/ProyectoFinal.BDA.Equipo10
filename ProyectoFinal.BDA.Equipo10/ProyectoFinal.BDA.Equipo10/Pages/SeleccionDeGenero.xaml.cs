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

//Al presionar el boton de actrices se abre la pagina Actrices
        private async void Actrices_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Actrices());
        }

        //Al presionar el boton de Actores se abre la pagina Actores
        private async void Actores_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Actores());
        }
    }
}
