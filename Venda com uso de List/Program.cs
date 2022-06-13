using System;
using System.Collections.Generic;


namespace Venda_com_uso_de_List
{
    enum TipoCadastro
    {
        CadastrarVendedor,
        CadastrarCliente,
        CadastrarProduto,
        CriarUmaVenda,
        InserirProdutoNoCarrinho,
        LimparCarrinho,
        FinalizarVenda
    }
    enum Produtos
    {
        Arroz,
        Feijão,
        Macarrão,
        Óleo,
        Leite,
        Açúcar
    }
    enum Vendedores
    {
        Mario,
        Jorge
    }
    enum Clientes
    {
        Luana,
        Janaina
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            bool Finalizada = true;

            List<Vendedor> vendedor = new List<Vendedor>();
            List<Cliente> cliente = new List<Cliente>();
            List<Venda> venda = new List<Venda>();
            List<Produto> produto = new List<Produto>();
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Produtos.Add(new Produto());

            vendedor.Add(new Vendedor("Mario", 10));
            vendedor.Add(new Vendedor("Jorge", 11));
            cliente.Add(new Cliente("Luana", 8521455811, "Rua H, 123 Itjaí-SC"));
            cliente.Add(new Cliente("Janaina", 4589512255, "Av. W, 45 Itajaí-SC"));
            produto.Add(new Produto("Arroz", "Lagoano", 5.80));
            produto.Add(new Produto("Feijão", "Lagoano", 6.20));
            produto.Add(new Produto("Macarrão", "Lagoano", 3.00));
            produto.Add(new Produto("Óleo", "Lagoano", 4.50));
            produto.Add(new Produto("Leite", "LAgoano", 4.80));
            produto.Add(new Produto("Açúcar", "Lagoano", 5.30));

            Console.WriteLine("Informe a opção desejada:\n 0 - Cadastrar um Vendedor \n 1 - Cadastrar um Cliente \n 2 - Cadastrar um Produto \n 3 - Criar uma Venda \n 4 - Inserir Produtos no Carrinho \n 5 - Limpar Carrinho \n 6 - Finalizar Venda");
            TipoCadastro tipoCadastro = (TipoCadastro)Convert.ToInt32(Console.ReadLine());

            if (tipoCadastro == TipoCadastro.CadastrarVendedor)
            {
                Console.WriteLine("Digite o nome do vendedor:");
                string Nome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o CPF do vendedor:");
                string CPF = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.CadastrarCliente)
            {
                Console.WriteLine("Digite o nome do cliente:");
                string Cliente = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o CPF do cliente:");
                string CPF = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o endereço do cliente:");
                string Endereco = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.CadastrarProduto)
            {
                Console.WriteLine("Digite a descrição do produto:");
                string Descricao = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite a marca do produto:");
                string Marca = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o preço do produto:");
                double Preco = Convert.ToDouble(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.CriarUmaVenda)
            {
                foreach (Produto p in produto)
                Console.WriteLine(p.DescricaoDoProduto + " " + p.Marca + " R$ " + p.Preco);
                Console.WriteLine("Informe o número referente ao produto desejado:\n 0 - Arroz \n 1 - Feijão \n 2 - Macarrão \n 3 - Óleo \n 4 - Leite \n 5 - Açucar \n");
                Produtos produtos = (Produtos)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero referente ao Vendedor \n 0 - Mario \n 1 - Jorge \n");
                Vendedores vendedores = (Vendedores)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o numero referente cliente \n 0 - Luana \n 1 - Janaina \n");
                Clientes cleintes= (Clientes)Convert.ToInt32(Console.ReadLine());
                //Como capturar os itens?
            }
            else if (tipoCadastro == TipoCadastro.InserirProdutoNoCarrinho)
            {
                tipoCadastro = (TipoCadastroprodutos;
                Console.WriteLine(Produtos);
                string InserirProdutoNoCarrinho = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.LimparCarrinho)
            {
                Console.WriteLine("Digite o nome do cliente:");
                string LimparCarrinho = Convert.ToString(Console.ReadLine());
            }
            else if (tipoCadastro == TipoCadastro.FinalizarVenda)
            {
                Console.WriteLine("Digite o nome do cliente:");
                string FinalizarVenda = Convert.ToString(Console.ReadLine());
            }




            //while (tipoCadastro == (int)TipoCadastro.CadastrarVendedor)



            
           






        }
    }
}
