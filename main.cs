using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    class MainClass
    {
        static FolhaPagamento RH = new FolhaPagamento();

        public static void Main(string[] args)
        {            
            RH.matricular (new CalculoSalario(1, "JORGE DOS SANTOS", 160));
            RH.matricular (new CalculoSalarioAposentado(2, "JOSE JOAO DA COSTA"));
            RH.matricular(new CalculoSalarioEstagiario(3, "ASPIRA RODRIGIGUES"));
            RH.imprimirFolha();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadKey();
         }
    }
}