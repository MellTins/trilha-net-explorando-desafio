namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTENTADO*
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTENTADO*
                throw new Exception("Não é possivel reservar! Capacidade do quarto é menor ao número de hóspedes");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            
                return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
          
            // *IMPLEMENTADO*

            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal valorComPercentual;
            decimal valorTotalComDesconto;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valorComPercentual = valor * 10 / 100;
                valorTotalComDesconto = valor - valorComPercentual;
                return valorTotalComDesconto;
            }

            return valor;

            
        }
    }
}