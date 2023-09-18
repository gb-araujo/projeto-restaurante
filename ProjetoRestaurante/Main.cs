using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRestaurante
{
    class Program
    {

        public static void Main(string[] args) {

            Comanda controleMesa = new Comanda(1);
            Caixa caixa = new Caixa();


            while(true) {
                Console.WriteLine("Bem-vindo \n selecione uma opção: \n 1- Lançar gastos \n 2 - Verificar promoção \n 3 - Fechar mesa \n 4 - Listar comanda \n 0 - Sair ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor do consumo:");
                        double valor1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do estacionamento:");
                        double valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do couvert:");
                        double valor3 = double.Parse(Console.ReadLine());

                        controleMesa.LancarGastos(valor1, valor2, valor3);
                        Console.WriteLine("Gastos lançados.");

                        break;

                    case 2:
                        controleMesa.VerificarPromocao();
                        Console.WriteLine($"Verificar promoção, seu desconto é de: {controleMesa.getValorPromocional()}");
                        break;

                    case 3:
                        Console.WriteLine("Fechando mesa, valor totalizado: " + caixa.totalizarComanda(controleMesa));
                        break;
                    case 4:
                        controleMesa.ListarComanda();
                        break;
                    case 0:
                        Console.WriteLine("Saindo.");
                        break;
                }

                if (opcao == 0)
                {
                    break;
                }
            }

        }


    }
}
