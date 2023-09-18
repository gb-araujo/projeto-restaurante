using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    public class Caixa
    {
        public double totalizarComanda(Comanda comanda)
        {
            double consumo = comanda.getValorConsumo();
            double estacionamento = comanda.getValorEstacionamento();
            double couvert = comanda.getValorCouvert();
            double soma = consumo + estacionamento + couvert;
            double total = soma - comanda.getValorPromocional();
            comanda.setValorTotal(total);
            return comanda.getValorTotal();

        }
    }
}
