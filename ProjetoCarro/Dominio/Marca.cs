using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoCarro.Dominio
{
    class Marca
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string pais { get; set; }
        public List<Carro> carro;
       



        public Marca(int codigo, string nome, string pais) 
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pais = pais;
            carro = new List<Carro>();
        }


        public void addCarro(Carro c) 
        {
            carro.Add(c);
            //carro.Sort();
        }


        public override string ToString()
        {
            return codigo
                + ", " + nome
                + ", "
                + pais
                +", Numero de carros: " + carro.Count;               
          
        }
    }
}
