
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

namespace POONelio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario Cidadao = new Funcionario();
            Console.Write("Nome:");
            Cidadao.Nome = Console.ReadLine();
            Console.Write("Salário Bruto:");
            Cidadao.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto:");
            Cidadao.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cidadao.SalarioLiquido();
            Console.WriteLine($"fucionario:{Cidadao.Nome}, {Cidadao.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)} ");
            Console.Write($"Digite a porcentagem para aumentar o salario:");
            double Porcen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Cidadao.AumentarSalario(Porcen);
            Console.WriteLine($"dados atualizados:{Cidadao.Nome}, { Cidadao.SalarioBruto.ToString("F2", CultureInfo.InvariantCulture)}");



        }


    }


}
