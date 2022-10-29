using System.Dynamic;
namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public Estacionamento(){ }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var input = Console.ReadLine();
            veiculos.Add(input);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var input = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == input.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var qtdHoras = int.Parse(Console.ReadLine());

                decimal valorTotal = 0;

                valorTotal = precoInicial + precoPorHora * qtdHoras;

                veiculos.Remove(input);

                Console.WriteLine($"O veículo {input} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach(var cars in veiculos){
                    System.Console.WriteLine("---------------------------------");
                    System.Console.WriteLine($"Veiculo: {cars} estacionado ");
                    System.Console.WriteLine("--------------------------------- \n");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
