using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
    public HospedagemContratada(Hospedagem h)
    {
        InitializeComponent();

        // Associa os dados recebidos aos elementos da tela
        BindingContext = h;

        // Gera um número de protocolo aleatório para o atendimento
        Random random = new Random();
        int numeroProtocolo = random.Next(100000, 999999);

        // Exibe o protocolo gerado no Label criado no XAML
        lblProtocolo.Text = $"Protocolo de Atendimento: #{numeroProtocolo}";
    }

    private async void BtnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}