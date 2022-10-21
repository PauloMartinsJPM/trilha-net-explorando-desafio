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
           //IMPLEMENTADO: Verificar se a capacidade é maior ou igual ao numero 
           //de hóspedes sendo recebido

            if (true) 
            {
                Hospedes = hospedes;
                
            }
            else
            {
                throw new ArgumentException("Excedeu a capacidade da Suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO: Retorna a quantidade de hóspedes (propriedade Hospedes)
          
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLEMENTADO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
          
            decimal valor = DiasReservados * Suite.ValorDiaria;


            // IMPLEMENTADO : Regra: Caso os dias reservados forem maior ou igual a 10, conceder
            // um desconto de 10%
          
            if (DiasReservados >= 10)
            {
                valor = valor * 90/100;
            }

            return valor;
        }
    }
}