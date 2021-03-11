using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    public class CalculoSalario : ICalcularSalario
    {
        public int Cod {get;set;}
        public string Nome {get;set;}
        public double Horas {get;set;}

        public CalculoSalario(int Cod,string Nome,double Horas)
        {
          this.Cod = Cod;
          this.Nome = Nome;
          this.Horas = Horas;
        }
        public double calcularSalario(double SalarioHora)
        {
           return SalarioHora * Horas;
        } 
        public void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("COD:{0}", Cod.ToString().PadLeft(8, '0'));
            Console.WriteLine("NOME:{0}", Nome.PadLeft(25, ' '));
            Console.WriteLine("_".PadLeft(50, '_'));
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
