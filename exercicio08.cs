using System;

namespace listaExercicios01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom Dia!!");

            Console.WriteLine("Digite o salário : ");
            string strSalario = Console.ReadLine();

            Console.WriteLine("Digite a Quantidade de carros Vendidos: ");
            string strCarrosVendidos = Console.ReadLine();

            Console.WriteLine("Digite a Comissão Fixa: ");
            string strComissaoFixa = Console.ReadLine();

            Console.WriteLine("Digite o Valor total de carros vendido no mês (R$): ");
            string strValorTotal = Console.ReadLine();

            double salarioFixo = Convert.ToInt32(strSalario);
            double carrosVendidos = Convert.ToInt32(strCarrosVendidos);
            double comissaoFixa = Convert.ToInt32(strComissaoFixa);
            double valorVendido = Convert.ToInt32(strValorTotal);

            double comissaoTotal = carrosVendidos * comissaoFixa;
            double comissaoValorDeVendas = valorVendido * 5 /100;

            double salarioTotal = salarioFixo + comissaoTotal + comissaoValorDeVendas;

            Console.WriteLine( " O salário total do Vendedor é : R$ " + salarioTotal );

        }
    }
}
