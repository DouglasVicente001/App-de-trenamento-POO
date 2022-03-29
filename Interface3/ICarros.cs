namespace TreinoFim.Interface3
{
    public interface ICarros
    {
         public string Carro { get; set; }
         public string  Cor { get; set; }
         public string  Ano { get; set; }
         public string  Estado { get; set; }
         public int Valor { get; set; }
         public string TipoVeiculo { get; set; }

         public void TipoCarro();
         public void Cores();
         public void AnoCarro();
         public void EstadoCarro();
         public void ValorCarro();
         public void Tipo();
    }
}