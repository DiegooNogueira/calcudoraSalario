using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    public class FolhaPagamento
    {
        public List<ICalcularSalario> Funcionarios { get; set; }

        public FolhaPagamento()
        {
            Funcionarios = new List<ICalcularSalario>();
        }

        public void matricular(ICalcularSalario empregado)
        {
            Funcionarios.Add(empregado);
            Console.WriteLine("Funcionário Matriculado...");
        }
         public void imprimirFolha()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("                 FOLHA DE PAGAMENTO                 ");
            Console.WriteLine("----------------------------------------------------");

            foreach (ICalcularSalario emp in Funcionarios)
            {
                emp.imprimir();
                double valor = 0;

                if (emp is CalculoSalario) valor = 21;
                if (emp is CalculoSalarioAposentado) valor = 23;
                if (emp is CalculoSalarioEstagiario) valor = 10;

                Console.WriteLine("Salario:{0}",
                    emp.calcularSalario(valor).ToString("C2"));
                Console.WriteLine();
            }

            Console.WriteLine("----------------------------------------------------");
        }
    }
}