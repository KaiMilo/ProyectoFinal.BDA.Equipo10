﻿using ProyectoFinal.BDA.Equipo10.DataModel;
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
            
            //A continuacion se crea una nueva ObservableCollection, esto para poner a los actores, usaremos el Binding para mostrar los datos

            grupo = new ObservableCollection<Actor>
            {
                new Actor{ Nombre = "Johnny Depp", Foto = "actor1.jpg", Desc = "John Christopher Depp II es un actor, productor de cine y músico estadounidense. Ha sido nominado en tres ocasiones al Óscar y recibió un Globo de Oro, un premio del Sindicato de Actores y un César.", DescLarga1 = "John Christopher Depp II (Owensboro, Kentucky; 9 de junio de 1963) es un actor, productor de cine y músico estadounidense. Ha sido nominado en tres ocasiones al Óscar y recibió un Globo de Oro,​ un premio del Sindicato de Actores y un César. ​Comenzó su carrera en la película de terror A Nightmare on Elm Street de 1984 como Glen Lantz, una de las víctimas de Freddy Krueger. Dos años después, en 1986, tuvo un papel de reparto en Platoon dirigido por Oliver Stone. Su papel de Tom Hanson en la serie de televisión 21 Jump Street lo convirtió en un ídolo adolescente. Mientras trabajaba en esta, Depp actuó en la película Edward Scissorhands, que le valió su primera nominación al Globo de Oro y reconocimiento por parte de la crítica. Posteriormente protagonizó la mayoría de las películas en las que trabajó, entre ellas Sleepy Hollow (1999), Pirates of the Caribbean: The Curse of the Black Pearl (2003) y sus respectivas secuelas, Charlie y la fábrica de chocolate (2005), Sweeney Todd: The Demon Barber of Fleet Street (2008), Alicia en el país de las maravillas (2010) y su secuela Alicia a través del espejo (2016), Animales fantásticos y donde encontrarlos (2016) y su secuela Animales fantásticos: Los crímenes de Grindelwald (2018), entre otras."},
                new Actor{ Nombre = "Brad Pitt", Foto = "actor2.jpg", Desc = "William Bradley Pitt, conocido como Brad Pitt, es un actor, modelo y productor de cine de origen estadounidense.", DescLarga2 ="William Bradley Pitt (Shawnee, Oklahoma; 18 de diciembre de 1963), conocido como Brad Pitt, es un actor, modelo y productor de cine de origen estadounidense. Además, por su trabajo interpretativo, ha sido nominado cuatro veces a los Premios Óscar, como productor en 2013 y como mejor actor de reparto en 2020 y dos Premios Globo de Oro, como mejor actor de reparto en 1995 y 2020.​ Su significativa presencia mediática se debe también a su consideración como uno de los hombres más atractivos del mundo. Pitt comenzó su carrera como actor al aparecer como invitado en programas de televisión, entre los cuales se incluye un papel en el serial televisivo de CBS, Dallas (1987). Posteriormente, obtuvo reconocimiento de la prensa con la interpretación del cowboy autoestopista que seduce al personaje de Geena Davis en la película Thelma & Louise (1991). Los primeros papeles de Pitt como protagonista fueron en producciones de alto presupuesto como: A River Runs Through It (1992) y Entrevista con el vampiro (1994). También participó junto con Anthony Hopkins en el drama Leyendas de pasión (1994), papel que le hizo obtener su primera nominación a los Premios Globo de Oro. En 1995, recibió ovación de la crítica por sus interpretaciones en el filme de suspense Se7en y en el de ciencia ficción Doce monos, siendo esta última la que lo hizo ganar un Globo de Oro en la categoría de «mejor actor de reparto» y una nominación al Premio Óscar. Cuatro años después, protagonizó el éxito de culto Fight Club (1999), y poco después actuó en el exitoso filme Ocean's Eleven (2001) en el papel de Rusty Ryan y lo mismo en sus secuelas, Ocean's Twelve (2004) y Ocean's Thirteen (2007). Sus máximos éxitos a nivel comercial han sido Troya (2004) y Sr. y Sra. Smith (2005). Pitt recibió su segunda nominación al premio de la Academia por su papel de Benjamin Button en la película El curioso caso de Benjamin Button (2008) y su tercera nominación cuatro años más tarde, en la misma categoría, por Moneyball (2011). En 2020, obtuvo el premio al mejor actor de reparto por Once Upon a Time in Hollywood."},
                new Actor{ Nombre = "Leonardo DiCaprio", Foto = "actor3.jpg", Desc = "Leonardo Wilhelm DiCaprio es un actor, productor de cine y ambientalista estadounidense. Ha recibido numerosos premios entre los que destacan un Óscar al mejor actor; un premio BAFTA al mejor actor por su actuación en El renacido.", DescLarga3= "Leonardo Wilhelm DiCaprio (pronunciado /diˈkaːprjo/) (Los Ángeles, California; 11 de noviembre de 1974) es un actor, productor de cine y ambientalista estadounidense. Ha recibido numerosos premios entre los que destacan un Óscar al mejor actor; un premio BAFTA al mejor actor por su actuación en El renacido (2015); dos Globos de Oro al mejor actor de drama por sus actuaciones en El aviador (2004) y El renacido; y un Globo de Oro al mejor actor de comedia o musical por El lobo de Wall Street (2013). Adicionalmente, ha ganado el premio del Sindicato de Actores, el Oso de Plata y un Premio Chlotrudis. Hasta 2019, sus películas habían recaudado aproximadamente 7200 millones de dólares, y ha estado ocho veces en la lista de los actores mejor pagados del año. Comenzó su carrera, a principios de la década de 1990, apareciendo en comerciales de televisión antes de actuar en roles recurrentes de series de televisión como en Santa Bárbara y Los problemas crecen. Hizo su debut fílmico en la comedia de ciencia ficción y/o terror Critters 3 en 1991, y recibió elogios de la crítica por su actuación en This Boy's Life en 1993. Obtuvo reconocimiento por sus trabajos posteriores en papeles como en ¿A quién ama Gilbert Grape? (1993)2 y Marvin's Room (1996), así como en papeles principales en The Basketball Diaries (1995) y Romeo + Julieta (1996), antes de alcanzar la fama mundial por la película de James Cameron de 1997, Titanic." },
                new Actor{ Nombre = "Jim Carrey", Foto = "actor4.jpg", Desc = "James Eugene «Jim» Carrey es un humorista, actor y cantante canadiense-estadounidense. Es conocido por sus interpretaciones de humor slapstick​ y por su trabajo ganó dos premios Globo de Oro y fue candidato a un premio BAFTA.", DescLarga4= "James Eugene «Jim» Carrey (Newmarket, Ontario; 17 de enero de 1962) es un humorista, actor y cantante canadiense-estadounidense. Es conocido por sus interpretaciones de humor slapstick y por su trabajo ganó dos premios Globo de Oro y fue candidato a un premio BAFTA. Empezó a trabajar a fines de la década de 1970 como comediante en vivo, en el club Yuk Yuk's de Toronto. Después de obtener cierto prestigio, en 1981 comenzó a trabajar en the Comedy Store de Los Ángeles, donde fue visto por el humorista Rodney Dangerfield, quien inmediatamente firmó con él la apertura de sus giras de actuaciones. Interesado en el cine y la televisión, desarrolló una amistad con Damon Wayans, que le consiguió un papel en el programa de humor In Living Color, en el que interpretó a varios personajes durante los años noventa. Después de obtener éxito en series de televisión y varias películas de bajo presupuesto, protagonizó la comedia Ace Ventura, que se estrenó en febrero de 1994. La película tuvo una secuela en 1995, Ace Ventura: When Nature Calls, en la que repitió el papel de detective de mascotas. Le siguieron papeles como el de Stanley Ipkiss en The Mask, que le valió una nominación al Globo de Oro, como mejor actor en una comedia o musical, Lloyd Christmas en Dumb and Dumber, ambas de 1994, y Fleetcher Reed en Liar Liar de 1997. En 1999 y 2000, ganó el Globo de Oro por sus actuaciones en The Truman Show y Man on the Moon."},
                new Actor{ Nombre = "Bruce Willis", Foto = "actor5.jpg", Desc = "Walter Bruce Willis es un actor y productor estadounidense cuya trayectoria comenzó en la industria televisiva durante los años 1980 y que ha aparecido en películas donde interpreta roles cómicos, dramáticos y de acción.", DescLarga5= "Walter Bruce Willis (Idar-Oberstein, Alemania Occidental; 19 de marzo de 1955) es un actor y productor estadounidense cuya trayectoria comenzó en la industria televisiva durante los años 1980 y que ha aparecido en películas donde interpreta roles cómicos, dramáticos y de acción. Es conocido por su interpretación del oficial John McClane en la serie Die Hard, que obtuvo buenas críticas y una recaudación considerable a partir del estreno de la primera cinta en 1988. Asimismo, ha aparecido en más de sesenta películas, entre las que se incluyen éxitos de taquilla como Pulp Fiction, Sin City, Doce Monos, El Quinto Elemento, Armageddon, El Sexto Sentido, El Protegido, Glass, Looper, Lucky Number Slevin y Los Indestructibles. Las películas en las que ha aparecido Willis han logrado sumar 7500 millones de dólares en las taquillas de todo el mundo, por lo que se le considera como uno de los actores más rentables en un rol estelar o secundario. Por sus interpretaciones, ha sido acreedor de varios premios, entre ellos dos premios Emmy, un Globo de Oro y cuatro Saturn."},
                new Actor{ Nombre = "Liam Neeson", Foto = "actor6.jpg", Desc = "William John Neeson34, es un actor británico. En 1976 comenzó a actuar en el Teatro lírico de Belfast, donde estuvo dos años. Su primer papel reseñable en el cine fue la película Excalibur de 1981.", DescLarga6= "William John Neeson (Ballymena, Antrim, Irlanda del Norte, 7 de junio de 1952), es un actor británico. En 1976 comenzó a actuar en el Teatro lírico de Belfast, donde estuvo dos años. Su primer papel reseñable en el cine fue la película Excalibur de 1981. En esa década también participó en filmes como The Bounty (1984), junto a Mel Gibson y Anthony Hopkins, La misión (1986), con Robert De Niro y Jeremy Irons o el wéstern Con su propia ley (1989), protagonizado por Patrick Swayze. La fama mundial le llegó con su interpretación de Oskar Schindler en la aclamada película La lista de Schindler (1993), dirigida por Steven Spielberg, un papel por el que fue nominado a los premios Óscar. Desde entonces, Liam Neeson ha interpretado papeles protagonistas en numerosos filmes como Rob Roy (1995), Michael Collins (1996), la adaptación de la novela Los Miserables en 1998, Star Wars: Episodio I - La amenaza fantasma (1999), el drama biográfico Kinsey (2004) y Batman Begins (2005). En 2008 la carrera del actor recibió un nuevo impulso que lo convirtió en un héroe del cine de acción gracias al estreno del filme francés Taken, primera entrega de una trilogía. En los últimos años, Neeson ha protagonizado otras películas de acción como El equipo A (2010), Furia de titanes (2010), Unknown (2011), The Grey (2012), The Dark Knight Rises (2012), Non-Stop (2014), Run All Night (2015), El pasajero (2018) y Men in Black: International (2019)."},
                new Actor{ Nombre = "Tom Cruise", Foto = "actor7.jpg", Desc = "Thomas Cruise Mapother IV, más conocido como Tom Cruise, es un actor y productor de cine estadounidense ganador de tres premios Globo de Oro. ", DescLarga7= "Thomas Cruise Mapother IV (Siracusa, Nueva York; 3 de julio de 1962), más conocido como Tom Cruise, es un actor y productor de cine estadounidense ganador de tres premios Globo de Oro. A lo largo de más de cuatro décadas de carrera ha protagonizado películas de gran éxito crítico y comercial como Top Gun (1986), El color del dinero (1986), Rain Man (1988), Nacido el 4 de julio (1989), Days of Thunder (1990), A few good men (1992), Entrevista con el vampiro (1994), Jerry Maguire (1996), Eyes Wide Shut (1999), Minority Report (2002), El último samurái (2003), Collateral (2004), La guerra de los mundos (2005), Valkyrie (2008), Jack Reacher (2012), Oblivion (2013), Al filo del mañana (2014), American Made (2017) y la saga de Misión imposible (1996-presente), entre otras. Cruise es considerado como uno de los actores mejor pagados y más influyentes de Hollywood. En 2020, con un patrimonio neto de 570 millones de dólares, fue calificado como el segundo actor más rico del mundo por la revista Forbes. Sus películas han recaudado en total más de 4.000 millones de dólares en los Estados Unidos y más de 10.000 millones de dólares a nivel mundial, convirtiendo a Cruise en uno de los actores más taquilleros de la industria del cine de todos los tiempos."},
                new Actor{ Nombre = "Harrison Ford", Foto = "actor8.jpg", Desc = "Harrison Ford es un actor estadounidense de cine y televisión. Debe su notoriedad a su colaboración con el guionista, productor y director George Lucas, que fue el primero en darle la posibilidad de ser actor. Sus papeles de Han Solo en la saga de Star Wars y de Indiana Jones lo elevaron al nivel de estrella internacional. ", DescLarga8= "Harrison Ford (Chicago, Illinois, 13 de julio de 1942) es un actor estadounidense de cine y televisión. Debe su notoriedad a su colaboración con el guionista, productor y director George Lucas, que fue el primero en darle la posibilidad de ser actor. Sus papeles de Han Solo en la saga de Star Wars y de Indiana Jones lo elevaron al nivel de estrella internacional. Aunque un fracaso inicial en taquilla, la película de Ridley Scott Blade Runner, donde desempeña el papel del cazador de replicantes Rick Deckard, terminó convirtiéndose en una película de culto de la ciencia ficción. Con más de cinco mil seiscientos millones de dólares recaudados en todo el mundo por sus películas, Ford es el actor con mayores ingresos en taquilla de la historia. En 1998 fue elegido, con cincuenta y seis años, el hombre vivo más sexy del mundo por la revista estadounidense People, y en 1995 por la británica Empire como uno de los cien actores más sexy de la historia (en el 15.º puesto)."},
            };

            lsvGrupo.ItemsSource = grupo;


        }

        private void lsvGrupo_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
