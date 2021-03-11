using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    public class CalculoSalarioEstagiario: ICalcularSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Auxilio { get; set; }

        public CalculoSalarioEstagiario(int Cod, string Nome)
        {
            this.Cod = Cod;
            this.Nome = Nome;
        }

        public double calcularSalario(double SalarioHora)
        {
            double salario = 80 * SalarioHora;
            this.Auxilio = salario * 0.03;
            Console.WriteLine("AUXILIO DO ESTAGIÁRIO:{0}", Auxilio.ToString("C2"));
            return salario + this.Auxilio;
        }

        public void imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("COD:{0}", Cod.ToString().PadLeft(8, '0'));
            Console.WriteLine("NOME DO ESTAGIÁRIO:{0}", Nome.PadLeft(25, ' '));
            Console.WriteLine("_".PadLeft(50, '_'));
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}