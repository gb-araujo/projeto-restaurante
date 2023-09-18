namespace ProjetoRestaurante
{
    public class Comanda
    {
        private int Id { get; set; }
        private double ValorConsumo { get; set; }
        private double ValorEstacionamento { get; set; }
        private double ValorCouvert { get; set; }
        private double ValorDescontoPromocional { get; set; }
        private double ValorTotal { get; set; }

        public Comanda(int id)
        {
            Id = id;
        }

        public void LancarGastos(double consumo, double estacionamento, double couvert)
        {
            this.ValorConsumo = consumo;
            this.ValorEstacionamento = estacionamento;
            this.ValorCouvert = couvert;
        }

        public void VerificarPromocao()
        {
            if (ValorConsumo > 100)
            {
                ValorDescontoPromocional = ValorConsumo * 0.1;
            }
            else
            {
                ValorDescontoPromocional = 0.0; 
            }
        }

        public string ListarComanda()
        {
            string comanda =
                $"Seu id é {Id} " +
                $"\nO valor de consumo é de {ValorConsumo} " +
                $"\nO valor de estacionamento é de {ValorEstacionamento} " +
                $"\nO valor do couvert foi de {ValorCouvert}" +
                $"\nO seu desconto foi de {ValorDescontoPromocional}";

            Console.WriteLine(comanda);

            return comanda;
        }

        public double getValorConsumo()
        {
            return this.ValorConsumo;
        }

        public double getValorEstacionamento()
        {
            return this.ValorEstacionamento;
        }

        public double getValorCouvert()
        {
            return this.ValorCouvert;
        }

        public double getValorPromocional()
        {
            return this.ValorDescontoPromocional;
        }
        public void setValorTotal(double valor)
        {
            ValorTotal = valor;
        }

        public double getValorTotal()
        {
            return this.ValorTotal;
        }

    }
}
