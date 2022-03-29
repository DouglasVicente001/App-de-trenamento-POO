using static System.Console;
namespace TreinoFim.Interface3
{
    public class TelaConcessionaria
    {
        public void Tela()
        {
            ModeloCarro carro = new ModeloCarro();
                  while(true )
                  {
                        string Apresentacao = "====== DOUGLAS MOTORS ======"+
                        "\nInsira o veículo que deseja pesquisar";
                        WriteLine(Apresentacao);
                  carro.TipoCarro();
                  carro.Cores();
                  carro.AnoCarro();
                  carro.EstadoCarro();
                  carro.ValorCarro();
                  carro.Tipo();
                  WriteLine ("\n====== DOUGLAS MOTORS ======"+
                  "\nNota Fiscal do veículo:"+"\n________________________");
                  carro.InfoTotal();
                  WriteLine("\nDeseja continuar avaliando veículos [S]Sim[N]Nao");
                  string Saida = ReadLine();
                  if (Saida.Equals("n",StringComparison.InvariantCultureIgnoreCase))
                  {
                        WriteLine("Obrigado por utilizar nosso app 'Douglas Motors'");
                        break;
                  }
                  }
        }
    }
}