using System;

namespace MauiAppHotel.Models
{
    public class Hospedagem
    {
        public Quarto QuartoSelected { get; set; }
        public int QtdAdultos { get; set; }
        public int QtdCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }

        // Propriedade que calcula o número de diárias (estadia)
        public int Estadia
        {
            get => (DataCheckOut - DataCheckIn).Days;
        }

        // Propriedade que calcula o valor total da reserva
        public double ValorTotal
        {
            get
            {
                double valor_adultos = QtdAdultos * QuartoSelected.ValorDiariaAdulto * Estadia;
                double valor_criancas = QtdCriancas * QuartoSelected.ValorDiariaCrianca * Estadia;

                return valor_adultos + valor_criancas;
            }
        }
    }
}