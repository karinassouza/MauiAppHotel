using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        pck_quarto.ItemsSource = new List<Quarto>
        {
            new Quarto
            {
               Descricao = "Suíte Premium (90 m²) - Serviço de Quarto",
               ValorDiariaAdulto = 220.0,
               ValorDiariaCrianca = 110.0
            },
            new Quarto
            {
               Descricao = "Suíte Super Luxo (60 m²) - Serviço de Quarto",
               ValorDiariaAdulto = 110.0,
               ValorDiariaCrianca = 55.0
            },
            new Quarto
            {
               Descricao = "Suíte Executiva (40 m²) - Sala Privada de Refeições",
               ValorDiariaAdulto = 90.0,
               ValorDiariaCrianca = 45.0
            },
            new Quarto
            {
               Descricao = "Suíte Casal (30 m²) - Salão com Comida à Vontade",
               ValorDiariaAdulto = 70.0,
               ValorDiariaCrianca = 35.0
            },
            new Quarto
            {
               Descricao = "Suíte Crise (20 m²) - Salão com Comida à Vontade",
               ValorDiariaAdulto = 45.0,
               ValorDiariaCrianca = 25.0
            }
        };
    }

    private async void BtnAvancar_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (pck_quarto.SelectedItem == null)
            {
                await DisplayAlert("Aviso", "Por favor, selecione um tipo de quarto.", "OK");
                return;
            }

            Hospedagem h = new Hospedagem
            {
                QuartoSelected = (Quarto)pck_quarto.SelectedItem,
                QtdAdultos = Convert.ToInt32(stp_adultos.Value),
                QtdCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = dtpck_checkin.Date ?? DateTime.Now,
                DataCheckOut = dtpck_checkout.Date ?? DateTime.Now
            };

            await Navigation.PushAsync(new HospedagemContratada(h));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private async void BtnSobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}