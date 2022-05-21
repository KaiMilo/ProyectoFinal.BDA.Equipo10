using ProyectoFinal.BDA.Equipo10.DataModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.BDA.Equipo10.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actores : ContentPage
    {
        ObservableCollection<Actor> grupo;
        public Actores()
        {
            InitializeComponent();

            grupo = new ObservableCollection<Actor>
            {
                new Actor{ Nombre = "Johnny Depp", Foto = "actor1.jpg", Desc = "John Christopher Depp II es un actor, productor de cine y músico estadounidense. Ha sido nominado en tres ocasiones al Óscar y recibió un Globo de Oro, un premio del Sindicato de Actores y un César."},
                new Actor{ Nombre = "Brad Pitt", Foto = "actor2.jpg", Desc = "William Bradley Pitt, conocido como Brad Pitt, es un actor, modelo y productor de cine de origen estadounidense."},
                new Actor{ Nombre = "Leonardo DiCaprio", Foto = "actor3.jpg", Desc = "Leonardo Wilhelm DiCaprio es un actor, productor de cine y ambientalista estadounidense. Ha recibido numerosos premios entre los que destacan un Óscar al mejor actor; un premio BAFTA al mejor actor por su actuación en El renacido."},
                new Actor{ Nombre = "Jim Carrey", Foto = "actor4.jpg", Desc = "James Eugene «Jim» Carrey es un humorista, actor y cantante canadiense-estadounidense. Es conocido por sus interpretaciones de humor slapstick​ y por su trabajo ganó dos premios Globo de Oro y fue candidato a un premio BAFTA."},
                new Actor{ Nombre = "Bruce Willis", Foto = "actor5.jpg", Desc = "Walter Bruce Willis es un actor y productor estadounidense cuya trayectoria comenzó en la industria televisiva durante los años 1980 y que ha aparecido en películas donde interpreta roles cómicos, dramáticos y de acción."},
                new Actor{ Nombre = "Liam Neeson", Foto = "actor6.jpg", Desc = "William John Neeson3​4​, es un actor británico. En 1976 comenzó a actuar en el Teatro lírico de Belfast, donde estuvo dos años. Su primer papel reseñable en el cine fue la película Excalibur de 1981."},
                new Actor{ Nombre = "Tom Cruise", Foto = "actor7.jpg", Desc = "Thomas Cruise Mapother IV, más conocido como Tom Cruise, es un actor y productor de cine estadounidense ganador de tres premios Globo de Oro. "},
                new Actor{ Nombre = "Harrison Ford", Foto = "actor8.jpg", Desc = "Harrison Ford es un actor estadounidense de cine y televisión. Debe su notoriedad a su colaboración con el guionista, productor y director George Lucas, que fue el primero en darle la posibilidad de ser actor. Sus papeles de Han Solo en la saga de Star Wars y de Indiana Jones lo elevaron al nivel de estrella internacional. "},
            };

            lsvGrupo.ItemsSource = grupo;


        }

        private void lsvGrupo_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}