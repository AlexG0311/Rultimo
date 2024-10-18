namespace Rultimo
{
    public partial class MainPage : ContentPage
    {
        int contador = 0;
      

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            contador++; // Incrementar el contador
            lblContador.Text = $"Has presionado el botón {contador} veces"; // Actualizar el texto del Label
        private void OnNewButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("New Button", "This button was added by a collaborator!", "OK");
        private void OnChangeColorButtonClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.LightBlue;
        }

    }

}
