namespace Calculadora_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operador = 0;

            Console.WriteLine("Calculadora C#");

            while (operador > 4 || operador < 1)
            {
                Console.WriteLine("Selecione a operação que deseja executar:");
                Console.Write("1 -> Soma\n2 -> Subtração\n3 -> Multiplicação\n4 -> Divisão\n");
                operador = int.Parse(Console.ReadLine());
                Console.Clear();
                if (operador > 4 || operador < 1)
                {
                    Console.WriteLine("Valor inválido");
                }
            }

            Console.WriteLine("Digite o primeiro valor");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor");
            float valor2 = float.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    Console.WriteLine($"Resultado: {valor1 + valor2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {valor1 - valor2}");
                    break;


            }
        }
    }
}
