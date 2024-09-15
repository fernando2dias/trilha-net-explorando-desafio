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
            var quantidadeHospedes = ObterQuantidadeHospedes(hospedes);
            if (quantidadeHospedes <= Suite.capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Capacidade insuficiente");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes(List<Pessoa> hospedes)
        {
            return hospedes.Count();
        }

        public decimal CalcularValorDiaria(decimal diaria, int diasReservados)
        {
            var total = diaria * diasReservados;
            return (diasReservados >= 10) ? total * 0.9 : total;
        }
    }
}