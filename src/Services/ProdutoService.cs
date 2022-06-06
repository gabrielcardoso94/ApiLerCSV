using src.Models;

namespace src.Services
{
    public class ProdutoService
    {
        public List<Produto> ObterTodos()
        {
            List<Produto> listaProdutos = new List<Produto>();

            using (StreamReader item = new StreamReader(@"../src/CSV/produtos.csv"))
            {
                while (!item.EndOfStream)
                {
                    string[] produtos = item.ReadLine().Split(';');
                    listaProdutos.Add(new Produto(int.Parse(produtos[0]), produtos[1], double.Parse(produtos[2])));
                }
            }

            return listaProdutos;
        }

        public Produto ObterPorId(int id)
        {
            var produto = ObterTodos().Find(p => p.Id == id);

            return produto;
        }
    }
}