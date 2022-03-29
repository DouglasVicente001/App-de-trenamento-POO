using static System.Console;
namespace TreinoFim.Interface
{
    public interface ICalculadora
    {
            public int  Num1 { get; set; }
            public int Num2 { get; set; }
            public int Total { get;set; }
            
            public void Soma();
            public void Subtracao();
            public void Divisao();
            public void Multiplicacao();
           
    }       
}