using static System.Console;
namespace TreinoFim.Models


{
    public class TelaMorador : Morador
    {
        public async void Tela()
        {   
            while(true)
            {

            string Mensagem = "====== CARTEIRO MEDROSO ======";
            WriteLine(Mensagem);

            Morador Morador1 = new Morador();

            int [] Casas = new int [7];
            int CasaImpar = 0;
            for(int i = 1; i <= 6;i++)
            {   
                
                WriteLine($"\nA {i}º casa tem cachorro? [S]Sim/[N]Nao ");
                string Opcao = ReadLine();
                
                if (Opcao.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                {   
                    
                    Morador1.getNmrCasa();
                    if (Casas[i] % 2 == 0)
                    {
                    CasaImpar = CasaImpar + 1;
                    }
                    WriteLine("Você entregou a correspondência");
                }

                else 
                {
                    WriteLine("Você correu para a próxima casa!!!");
                }
                
            }
            WriteLine($"\nNumero de correspondencias ímpares entregues {CasaImpar}");
           
            WriteLine("Deseja continuar no app 'Carteiro Medroso'? [S]Sim[N]Nao");
            string Decisao = ReadLine();
            if (Decisao.Equals("n",StringComparison.InvariantCultureIgnoreCase))
            {
                WriteLine("Obrigado,espero que tenha gostado do app 'Carteiro Medroso");
                break;
            }
            }
        }
    }
}