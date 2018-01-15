using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProjetoCarro.Dominio
{
    class Carro
    {
        public int codigo { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }
        public double precoBasico { get; set; }
        public Marca marca { get; set; }


        public Carro(int codigo, string modelo, int ano, double precoBasico, Marca marca) 
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;
            this.marca = marca;
        }


       /* public double precoTotal() 
        {
        
        
        }*/


        public override string ToString()
        {
            return codigo + ", " + modelo + ", " + ano + ", " + precoBasico;
        }
    }
}
