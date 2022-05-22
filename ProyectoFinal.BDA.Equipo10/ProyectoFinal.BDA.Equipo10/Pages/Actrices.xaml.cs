using ProyectoFinal.BDA.Equipo10.DataModel;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.BDA.Equipo10.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actrices : ContentPage
    {
        ObservableCollection<Actriz> grupo2;
        public Actrices()
        {
            InitializeComponent();
            
            //A continuacion se crea una nueva ObservableCollection, esto para poner a las actrices, usaremos el Binding para mostrar los datos


            grupo2 = new ObservableCollection<Actriz>
            {
                new Actriz{ Nombre = "Scarlett Johansson", Foto = "actriz1.jpg", Desc = "Scarlett Ingrid Johansson es una actriz, cantante, directora, productora y empresaria estadounidense. Comenzó a mostrar intereses en la actuación desde temprana edad, y a lo largo de su infancia y adolescencia se formó en distintos institutos como actriz."},
                new Actriz{ Nombre = "Natalie Portman", Foto = "actriz2.jpg", Desc = "Natalie Portman Millepied es una actriz, directora, productora y psicóloga israelí nacionalizada estadounidense. Es una de las pocas actrices que ha ganado los cuatro premios más importantes del cine por una misma película"},
                new Actriz{ Nombre = "Emma Watson", Foto = "actriz3.jpg", Desc = "Emma Charlotte Duerre Watson es una actriz, modelo y activista británica nacida en Francia, conocida principalmente por haber interpretado el personaje de Hermione Granger en la saga de películas de Harry Potter."},
                new Actriz{ Nombre = "Angelina Jolie", Foto = "actriz4.jpg", Desc = "Angelina Jolie Voight es una actriz, cineasta y embajadora de buena voluntad estadounidense. A lo largo de su carrera, Jolie ha recibido varios reconocimientos por sus logros cinematográficos, entre ellos dos Premios Óscar "},
                new Actriz{ Nombre = "Penélope Cruz", Foto = "actriz5.jpg", Desc = "Penélope Cruz Sánchez, más conocida como Penélope Cruz, es una actriz española. En 2006 fue la primera actriz española candidata a los Premios Óscar y a los Globos de Oro en la categoría de mejor actriz protagonista"},
                new Actriz{ Nombre = "Charlize Theron", Foto = "actriz6.jpg", Desc = "Charlize Theron es una actriz y modelo sudafricana-estadounidense. Alcanzó la fama después de participar en varias producciones cinematográficas en la década de los noventa"},
                new Actriz{ Nombre = "Demi Moore", Foto = "actriz7.jpg", Desc = "Demetria Gene Guynes, conocida profesionalmente como Demi Moore, es una actriz, modelo y productora estadounidense. Después de realizar papeles pequeños en películas y un papel recurrente en la serie de televisión General Hospital, Moore estableció su carrera en la década de 1990."},
                new Actriz{ Nombre = "Nicole Kidman", Foto = "actriz8.jpg", Desc = "Nicole Mary Kidman, es una actriz, productora y cantante australiana-estadounidense. Ha recibido numerosos galardones, incluidos un Premio Óscar, un Premio BAFTA, un Premio del Sindicato de Actores de la Pantalla, dos Premios Primetime Emmy y seis Globos de Oro. "},
            };

            lsvGrupo2.ItemsSource = grupo2;

        }
        //CUando se presiona se abre la página Descripcion_Actriz con el item seleccionado
        private async void lsvGrupo2_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            Actriz item = (Actriz)e.Item;
            if (item != null)
            {
                await Navigation.PushAsync(new Descripcion_Actriz(item));
            }

        }
    }
}
