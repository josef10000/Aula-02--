namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 10, B = 20, temp;

            Console.WriteLine("Antes da troca: A = {0}, B = {1}", A, B);

            temp = A;
            A = B;
            B = temp;

            Console.WriteLine("Depois da troca: A = {0}, B = {1}", A, B);

            Console.ReadKey();
        }
    }
}