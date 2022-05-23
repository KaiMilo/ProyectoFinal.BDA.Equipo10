using Xamarin.Forms.Xaml;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

//Exportamos las fuentes que vamos usar en el proyecto

[assembly: ExportFont("Baloo2-ExtraBold.ttf",Alias = "Baloo2-EB")]
[assembly: ExportFont("Baloo2-VariableFont_wght.ttf", Alias ="Baloo2-Normal")]
[assembly: ExportFont("BalooDa2-VariableFont_wght.ttf", Alias ="BalooDa2-Normal")]
[assembly: ExportFont("BalooTamma2-VariableFont-wght.ttf", Alias = "BalooTamma2")]
