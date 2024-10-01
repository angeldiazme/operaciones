using Microsoft.Maui.Controls;
namespace operaciones

{
    public partial class MainPage : ContentPage
    {
        private double resultado;


        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnSumaClicked(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                resultado = double.Parse(Numero1.Text) + double.Parse(Numero2.Text);
                await NavegarAResultado();
            }
        }

        private async void OnRestaClicked(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                resultado = double.Parse(Numero1.Text) - double.Parse(Numero2.Text);
                await NavegarAResultado();
            }
        }

        private async void OnMultiplicaClicked(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                resultado = double.Parse(Numero1.Text) * double.Parse(Numero2.Text);
                await NavegarAResultado();
            }
        }

        private async void OnDivideClicked(object sender, EventArgs e)
        {
            if (ValidarEntradas())
            {
                if (double.Parse(Numero2.Text) != 0)
                {
                    resultado = double.Parse(Numero1.Text) / double.Parse(Numero2.Text);
                    await NavegarAResultado();
                }
                else
                {
                    await DisplayAlert("Error", "No se puede dividir por cero", "OK");
                }
            }
        }

        private bool ValidarEntradas()
        {
            if (string.IsNullOrEmpty(Numero1.Text) || string.IsNullOrEmpty(Numero2.Text))
            {
                DisplayAlert("Error", "Por favor ingrese ambos números", "OK");
                return false;
            }

            return true;
        }

        private async Task NavegarAResultado()
        {
            await Navigation.PushAsync(new ResultadoPage(resultado));
        }

    }

}
