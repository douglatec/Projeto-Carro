﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoCarro.Dominio;

namespace ProjetoCarro
{
    class Program
    {
        public static List<Marca> listaDeMarca = new List<Marca>();
        public static List<Carro> listaDeCarro = new List<Carro>();

        


        static void Main(string[] args)
        {
            
            int opcao = 0;

            Marca m1 = new Marca(1001,"Volkswagem","Alemanha");
            Marca m2 = new Marca(1002,"General Motors","Estados Unidos");

            Carro c1 = new Carro(101,"Fusca",1980,5000.00,m1);
            m1.addCarro(c1);
            Carro c2 = new Carro(102,"Golf",2016,60000.00,m1);
            m1.addCarro(c2);
            Carro c3 = new Carro(103,"Fox",2017,30000.00,m1);
            m1.addCarro(c3);
            Carro c4 = new Carro(104,"Cruze",2016,30000.00,m2);
            m2.addCarro(c4);
            Carro c5 = new Carro(105,"Cobalt",2015,25000.00,m2);
            m2.addCarro(c5);
            Carro c6 = new Carro(106,"Cobalt",2017,35000.00,m2);
            m2.addCarro(c6);

            listaDeMarca.Add(m1);
            listaDeMarca.Add(m2);

            listaDeCarro.Add(c1);
            listaDeCarro.Add(c2);
            listaDeCarro.Add(c3);
            listaDeCarro.Add(c4);
            listaDeCarro.Add(c5);
            listaDeCarro.Add(c6);

            

           //Console.WriteLine(listaDeCarro.Count());

            while (opcao!=7) 
            {
            
            Console.Clear();
            Tela.mostrarMenu();
                opcao = int.Parse(Console.ReadLine());
            
                if (opcao==1)
                {

                for(int i=0;i<listaDeMarca.Count;i++)
                {
                Console.WriteLine(listaDeMarca[i]);
                }
                
                }
                else if (opcao==2)
                {
                    Tela.listarCarrosDeUmaMarca();
                
                }

             Console.ReadLine();
            
            }

        


           



            



        }
    }
}
