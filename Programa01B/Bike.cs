using System.Diagnostics.Contracts;

namespace Programa01B
{
    class Bike
    {
        //DECLARAÇÕES
        public string? Modelo { get; set; }
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes{ get; set; }
        //METODOS (AÇOES)
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool peso = PesoCiclista > 90.0;
            //se o peso for acima de 90 kg reduz para 15% autonomia 
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;
        }
        public double CalcularConsumoMensal()
        {
            double cargaPorKm = Bateria / 1000.0;
            return cargaPorKm * RecargaMes;
        }
        public double CaucularCustoMensal()
        {
            const double PRECO = 0.80;
            return CalcularConsumoMensal() * PRECO;
        }
        public bool BikeEconomica()
        {
            return (CalcularConsumoMensal() < 15.00) || (CalcularAutonomia() > 40.0);
        }

   }
}

