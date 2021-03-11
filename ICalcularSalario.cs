using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSalarioInterface3DTB
{
    public interface ICalcularSalario
    {
       double calcularSalario (double SalarioHora); 
       void imprimir();
    }
}