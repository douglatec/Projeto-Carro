using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using ProjetoCarro.Dominio;

namespace ProjetoCarro
{
    class Tela
    {

        public static void mostrarMenu() 
        {
            Console.WriteLine("1 – Listar marcas");
            Console.WriteLine("2 – Listar carros de uma marca ordenadamente*");
            Console.WriteLine("3 – Cadastrar marca");
            Console.WriteLine("4 – Cadastrar carro");
            Console.WriteLine("5 – Cadastrar acessório");
            Console.WriteLine("6 – Mostrar detalhes de um carro");
            Console.WriteLine("7 – Sair");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");
                   
        }


        public static void ListagemDeMarcas() 
        {
            Console.WriteLine("LISTAGEM DE MARCAS:");
            for (int i = 0; i < Program.listaDeMarca.Count; i++)
            {
                Console.WriteLine(Program.listaDeMarca[i]);
            }
            Console.WriteLine();
        }



        public static void listarCarrosDeUmaMarca() 
        {
            Console.Write("Digite o código da marca: ");
            int CodMarca = int.Parse(Console.ReadLine());
            int pos = Program.listaDeCarro.FindIndex(x => x.codigo == CodMarca);
            if(pos==-1)
            {
                throw new ModelException("Codigo de marca não encontrado: " + CodMarca);
            }
            Console.WriteLine("Carros da marca"+Program.listaDeMarca[pos].nome+":");
            List<Carro> lista = Program.listaDeMarca[pos].carro;
            for (int i = 0; i < lista.Count;i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
         }



        public static void cadastrarMarca() 
        {
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Pais de origem: ");
            string pais = Console.ReadLine();
            Marca m = new Marca(codigo,nome,pais);
            Program.listaDeMarca.Add(m);      
        
        }



        public static void cadastrarCarro() 
        {
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (codigo): ");
            int codMarca = int.Parse(Console.ReadLine());
            int pos = Program.listaDeMarca.FindIndex(x=> x.codigo == codMarca);
            if(pos==-1)
            {
                throw new ModelException("Codigo de marca não encontrada: "+codMarca);
            }
            Console.Write("Codigo do carro: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Preço basico: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Marca m = Program.listaDeMarca[pos];
            Carro c = new Carro(codigo,modelo,ano,preco,m);
            m.addCarro(c);
            Program.listaDeCarro.Add(c);  

        }



        public static void cadastrarAcessorio() 
        {
            Console.WriteLine("Digite os dados do acessorio: ");
            Console.Write("Carro (codigo): ");
            int codCarro = int.Parse(Console.ReadLine());
            int pos = Program.listaDeCarro.FindIndex(x => x.codigo == codCarro);
            if(pos==-1)
            {
                throw new ModelException("Codigo de carro não encontrado: "+codCarro);           
            }
            Console.Write("Descrição: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Carro c = Program.listaDeCarro[pos];
            Acessorio a = new Acessorio(nome,preco,c);
            c.acessorios.Add(a);        
        }


        public static void mostrarCarro (List<Carro>carro)
        {
       Console.Write("Digite o codigo do carro: ");
        int codCarro = int.Parse(Console.ReadLine());
        int pos = carro.FindIndex(x => x.codigo == codCarro);
            if(pos==-1)
            {
                throw new ModelException("Codigo de carro não encontrado: " + codCarro);
            }
            Console.WriteLine(carro[pos]);
            Console.WriteLine();   
        }        
    }
}
