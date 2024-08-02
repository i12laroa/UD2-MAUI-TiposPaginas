namespace UD2_MAUI_TiposPaginas
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageDemo());
        }
    }

}
