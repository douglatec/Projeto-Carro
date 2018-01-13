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


        public Carro(int codigo, string modelo, int ano, double precoBasico) 
        {
            this.codigo = codigo;
            this.modelo = modelo;
            this.ano = ano;
            this.precoBasico = precoBasico;        
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
