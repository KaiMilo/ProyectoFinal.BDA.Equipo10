using ProyectoFinal.BDA.Equipo10.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoFinal.BDA.Equipo10.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Descripcion_Actriz : ContentPage
    {
        public Descripcion_Actriz(Actriz act)
        {
            InitializeComponent();
            Actriz act1 = act;


            //SE ponen los datos correspondientes para que se muestre el actor en la pantalla
            Nombre.Text = act1.Nombre;
            Image.Source = act1.Foto;
            Desc.Text = act1.LargeDesc;
        }
    }
}
