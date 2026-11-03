using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada(Hospedagem h)
    {
        InitializeComponent();

        // Associa os dados recebidos aos elementos da tela
        BindingContext = h;
    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}