using System.Globalization;
namespace Overcharge
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        // public Produto()
        // {
        //     Nome = "Novo produto";
        //     Preco = 0.0;
        //     Quantidade = 0; 
        // }

      
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}