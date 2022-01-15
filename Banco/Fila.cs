namespace Banco
{
    public static class Fila
    {

        public static void ShowValue(this Queue<Cliente> queue) {
            Console.WriteLine($"Cliente com Nome: {queue.Peek().nome}");
        }

        public static void Adicionar(this Queue<Cliente> queue){
            Console.ReadLine();
            Console.WriteLine("Adicionando um Cliente da fila...");
            Console.WriteLine("Insira seu nome...");
            var nome = Console.ReadLine();
         
            var cliente = new Cliente(){
                nome = nome,
                preferencial = false,
            };
            
            queue.Enqueue(cliente);
        }

        public static Queue<Cliente> AdicionarAntes(this Queue<Cliente> queue){
            Console.ReadLine();
            Console.WriteLine("Adicionando um Cliente preferencial da fila...");
            Console.WriteLine("Insira seu nome...");
            var nome = Console.ReadLine();

            var listPreferencial = queue.Where(x => x.preferencial == true).ToList();
            var listCommon = queue.Where(x => x.preferencial == false).ToList();

            var cliente = new Cliente(){
                nome = nome,
                preferencial = true
            };

            listPreferencial.Add(cliente);
            listPreferencial.AddRange(listCommon);
            return new Queue<Cliente>(listPreferencial);
        }

        public static void Remover(this Queue<Cliente> queue){
            Console.WriteLine("Removendo um cliente da fila...");
            queue.Dequeue();
        }
    }
}