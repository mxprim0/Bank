namespace DIO.Bank
{
    public class Conta
    {
        // Atributos da Classe
        private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }
        private string Nome { get; set; }

        // Método Construtor que vai ser chamado no momento que a classe for instanciada
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
    }
}