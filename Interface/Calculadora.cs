using static System.Console;
namespace TreinoFim.Interface
{
    public class Calculadora : ICalculadora
    {
        public int  Num1 { get; set; }
        public int Num2 { get; set; }
        public int Total { get;set; }
        public void Soma()
            {
                WriteLine("Digite o 1º valor: ");
                Num1 = int.Parse(ReadLine());
                WriteLine("Digite o 2º valor: ");
                Num2= int.Parse(ReadLine());
                Total = Num1 + Num2;
                WriteLine($"O resultado da soma é: {Total}");
            }
        public void Subtracao()
            {
                WriteLine("Digite o 1º valor: ");
                Num1 = int.Parse(ReadLine());
                WriteLine("Digite o 2º valor: ");
                Num2= int.Parse(ReadLine());
                Total = Num1 - Num2;
                WriteLine($"O resultado da subtração é: {Total}");
            }
        public void Multiplicacao()
            {
                WriteLine("Digite o 1º valor: ");
                Num1 = int.Parse(ReadLine());
                WriteLine("Digite o 2º valor: ");
                Num2= int.Parse(ReadLine());
                Total = Num1 * Num2;
                WriteLine($"O resultado da multiplicação é: {Total}");
            }
        public void Divisao()
        {
                WriteLine("Digite o 1º valor: ");
                Num1 = int.Parse(ReadLine());
                WriteLine("Digite o 2º valor: ");
                Num2= int.Parse(ReadLine());
                Total = Num1 / Num2;
                WriteLine($"O resultado da divisão é: {Total}");

        }

    }
}