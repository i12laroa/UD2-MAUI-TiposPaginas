namespace UD2_MAUI_TiposPaginas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

          //  var navPage = new NavigationPage(new MainPage());
            //Modificar los atributos de las barras de navegación
          //  navPage.BarBackground = Colors.Chocolate;
          //  navPage.BarTextColor = Colors.White;
            // MainPage = navPage;
             MainPage = new FlyoutPageDemo();
           // MainPage= new TabbedPageDemo();
        }
    }
}
