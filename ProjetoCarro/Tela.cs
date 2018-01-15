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



        public static void listarCarrosDeUmaMarca() 
        {
            Console.Write("Digite o código da marca: ");
            int codMarca = int.Parse(Console.ReadLine());
            Console.WriteLine("Carros da marca General Motors:");
            for (int i = 0; i < Program.listaDeCarro.Count;i++)
            {
                Console.WriteLine(Program.listaDeCarro[i]);
            }  

         }




    }
}
