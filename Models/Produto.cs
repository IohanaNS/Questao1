using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Domain.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return "Produto escolhido: \nCodigo: "+this.Codigo + " \nDescricao: " + this.Descricao + "\nPreço: R$ "+this.Preco;
        }
        
    }
   

}
