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

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // IMPLEMENTADO!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine(); // Lê a placa digitada pelo usuário
            veiculos.Add(placa); // Adiciona a placa à lista de veículos
            Console.WriteLine("Veículo com a placa " + placa + " foi estacionado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine().ToUpper();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // IMPLEMENTADO!

            // Verifica se o veículo existe
            int horas = 0;
            decimal valorTotal = 0; 
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                 if (int.TryParse(Console.ReadLine(), out horas))
                {
                    valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal:F2}"); // Exibe o valor com duas casas decimais
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida.");
                }

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // IMPLEMENTADO!


                // TODO: Remover a placa digitada da lista de veículos
                // IMPLEMENTADO!

                
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // IMPLEMENTADO!
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
