using System;

namespace ProgramaHerancaVeiculo
{
    enum TipoVeiculo
    {
        Trator,
        Caminhao,
        Moto
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tipo de veículo:\n 0 - Trator \n 1 - Caminhão \n 2 - Moto");
            TipoVeiculo tipoveiculo = (TipoVeiculo)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tipo de Veículo:");
            string Veiculo = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Chassi:");
            string Chassi = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Ano:");
            string Ano = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Modelo:");
            string Modelo = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Marca:");
            string Marca = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Preço:");
            double Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Motor:");
            string Motor = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("País de Origem:");
            string PaisDeOrigem = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Tipo de Combustível:");
            string TipoDeCombustivel = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Descrição do Motor:");
            string DescricaoMotor = Console.ReadLine();
            Console.WriteLine(); Console.WriteLine("Potência:");
            double Potencia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(); Console.WriteLine("Torque:");
            double Torque = Convert.ToDouble(Console.ReadLine());

            if (tipoveiculo == TipoVeiculo.Trator)
            {
                Console.WriteLine(); Console.WriteLine("Tipo de Tração:");
                string TipoDeTracao = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Tipo de Uso:");
                string TipoUso = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Tipo de Caçamba:");
                String TipoDeCacamba = Console.ReadLine();
            }
            if (tipoveiculo == TipoVeiculo.Caminhao)
            {
                Console.WriteLine(); Console.WriteLine("Quantidade de Eixos:");
                string Eixos = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Peso Bruto:");
                string PesoBruto = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Modulo de Carga:");
                string ModuloDeCarga = Console.ReadLine();
            }
            if (tipoveiculo == TipoVeiculo.Moto)
            {
                Console.WriteLine(); Console.WriteLine("Relação:");
                string Relacao = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Manetes:");
                string Manetes = Console.ReadLine();
                Console.WriteLine(); Console.WriteLine("Tipo de Partida:");
                string TipoDePartida = Console.ReadLine();
            }


            Modelo modelo = new Modelo(Modelo);
            //Motor motor = new Motor(TipoDeMotor, TipoDeCombustivel, DescricaoMotor, Potencia, Torque);
            //Marca marca = new Marca(Descricao, PaisDeOrigem);
            Veiculo veiculo = new Veiculo(Chassi, Ano, Preco);
            //Trator trator = new Trator(TipoDeTracao, TipoDeUso, TipoDeCacamba, veiculo.Modelo, veiculo.Marca, veiculo.Motor);


            Console.WriteLine("Nome:" + Veiculo);
            Console.WriteLine("Chassi:" + Chassi);
            Console.WriteLine("Ano:" + Ano);
            //Console.WriteLine("Modelo:" + trator.Modelo.Descricao);
            //Console.WriteLine("Marca:" + trator.Marca.Descricao);
            Console.WriteLine("Preco:" + Preco);
            //Console.WriteLine("Motor:" + trator.Motor.TipoDeMotor);
           // Console.WriteLine("Tipo de tração:" + trator.TipoDeTracao);
           // Console.WriteLine("Tipo de Uso:" + trator.TipoDeUso);
           // Console.WriteLine("Tipo de Caçamba:" + trator.TipoDeCacamba);
            //Console.WriteLine("Eixos:" + Eixos);
            //Console.WriteLine("Peso Bruto:" + PesoBruto);
            //Console.WriteLine("Modulo de Carga:" + ModuloDeCarga);
            //Console.WriteLine("Relacao:" + Relacao);
            //Console.WriteLine("Manetes:" + Manetes);
            //Console.WriteLine("Tipo de Partida:" + TipoDePartida);
















        }
    }
}
