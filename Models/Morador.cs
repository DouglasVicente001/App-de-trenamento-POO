using static System.Console;
namespace TreinoFim.Models
{
    public class Morador
    {
    private int Casa;
    private string Tel;

    
        public void getNmrCasa()
        {
            WriteLine("Digite o numero da casa: ");
            Tel = ReadLine();
        }   
        public void getTel()
        {
            WriteLine("Digite o numero de telefone: ");
            Tel = ReadLine();
            
        }
    }
}