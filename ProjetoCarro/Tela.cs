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

        
    }
}
