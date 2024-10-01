using Microsoft.Maui.Controls;
namespace operaciones;

public partial class ResultadoPage : ContentPage
{
	public ResultadoPage(double resultado)
	{
		InitializeComponent();
        ResultadoLabel.Text = $"El resultado es: {resultado}";
    }

    private async void OnVolverClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}