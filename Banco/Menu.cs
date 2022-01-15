namespace Banco
{
    public class Menu
    {
         private Queue<Cliente> queue = new Queue<Cliente>();
        // Solução add uma propriedade ou campo de acesso full e manter como singleton a instancia
        // Outra solução: arquivo, banco de dados
        public void MenuBasic() {
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Sou cliente");
            Console.WriteLine("2. Caixa");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    MenuCliente();
                    break;
                case '2':
                    MenuCaixa();
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            MenuBasic();
        }

        private void MenuCaixa() {
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Mostrar Cliente");
            Console.WriteLine("2. Finalizar Atendimento do Cliente");
            Console.WriteLine("3. Voltar");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    queue.ShowValue();
                    break;
                case '2':
                    queue.Remover();
                    break;
                case '3':
                    MenuBasic();
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            MenuCaixa();
        }

        private void MenuCliente() {
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            
            Console.WriteLine("Escolha uma das opções...");
            Console.WriteLine("1. Sou Preferencial");
            Console.WriteLine("2. Sou Normal");
            Console.WriteLine("3. Estou com Pressa");
            Console.WriteLine("9. Voltar");
            Console.WriteLine("0. Sair");
            Console.Write("Opção: ");

            switch (Console.Read())
            {
                case '1':
                    Console.WriteLine("Carregando, espere um pouco até finalizar");
                    System.Threading.Thread.Sleep(5000); // simulando um banco real
                    queue = queue.AdicionarAntes();
                    break;
                case '2':
                    Console.WriteLine("Carregando, espere um pouco até finalizar");
                    System.Threading.Thread.Sleep(10000); // simulando um banco real
                    queue.Adicionar();
                    break;
                case '3':
                    Console.WriteLine("Carregando, espere um pouco até finalizar");
                    System.Threading.Thread.Sleep(60000); // simulando um banco real, ps quando vc tem pressa sempre demora mais
                    queue.Adicionar();
                    break;
                case '9':
                    MenuBasic();
                    break;
                case '0':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida, tente novamente...");
                    break;
            }
            MenuCliente();
        }
    }
}