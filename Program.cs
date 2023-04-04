namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            double num1, num2, media;

            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            media = (num1 + num2) / 2;

            Console.WriteLine("A média aritmética entre {0} e {1} é: {2}", num1, num2, media);

            Console.ReadKey();
        }
    }
}