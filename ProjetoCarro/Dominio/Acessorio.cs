using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCarro.Dominio
{
    class Acessorio
    {
        public string nome { get; set; }
        public double preco { get; set; }


        public Acessorio(string nome, double preco) 
        {
            this.nome = nome;
            this.preco = preco;        
        }


       /* public override string ToString()
        {
            return ;
        }*/
    }
}
