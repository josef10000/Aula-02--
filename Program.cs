namespace Execicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a data (DDMMAAAA): ");
            string data = Console.ReadLine();

            // Converte a data para o formato AAAAMMDD
            string dataAAAAMMDD = data.Substring(4, 4) + data.Substring(2, 2) + data.Substring(0, 2);

            // Converte a data para o formato AAMMDD
            string dataAAMMDD = data.Substring(6, 2) + data.Substring(2, 2) + data.Substring(0, 2);

            Console.WriteLine("Data no formato AAAAMMDD: " + dataAAAAMMDD);
            Console.WriteLine("Data no formato AAMMDD: " + dataAAMMDD);

            Console.ReadKey();
        }
    }
}