using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    public class CalculoSalarioAposentado : ICalcularSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }

        public CalculoSalarioAposentado(int Cod, string Nome)
        {
            this.Cod = Cod;
            this.Nome = Nome;
        }

        public double calcularSalario(double SalarioHora)
        {
            double salario = 160 * SalarioHora;
            if (salario > 5980) return 5980;
            else return salario;
        }

        public void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("COD:{0}", Cod.ToString().PadLeft(8, '0'));
            Console.WriteLine("NOME DO APOSENTADO:{0}", Nome.PadLeft(25, ' '));
            Console.WriteLine("_".PadLeft(50, '_'));
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}