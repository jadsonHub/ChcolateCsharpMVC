using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoChocolate.Models
{
    public class Chocolate
    {   
        [Key]
        public int Id_Chocolate{ get; set; }
        public string Marca {get; set; }
        public double Porcent_Cacau {get; set;}
        public string Tipo { get; set; }
        public DateTime Data_Validade { get; set; }
        public double Preco{ get; set; }
        public double Porcent_Desconto { get; set; }

        public double CalcularDesconto(double preco, double desconto)
        {  
            double Res = preco - (preco*(desconto/100));
            return Res;
        }
    }
         
}