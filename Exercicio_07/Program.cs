using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            float vc, vt, vp, vd;

            Console.Write("Digite o valor da compra ");
            vc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

   string mensagem = "Escolha a forma de pagamento:\n" +
                     "\n 1-Pagamento a vista(15% de desconto)" +
                     "\n 2-Pagamento cheque pré-datado para 30 dias(10% de desconto)" +
                     "\n 3-Pagamento parcelado em 3x(5% de desconto)" +
                     "\n 4-Pagamento parcelado em 6x" +
                     "\n 5-Pagamento parcelado em 12x(8% de juros)";
            Console.WriteLine(mensagem);

            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1:
                    vt = (vc * 15 / 100);
                    vp = vc - vt;
                    Console.WriteLine("Valor a pagar é " + vp);
                    break;
                case 2:
                    vt = (vc * 10 / 100);
                    vp = vc - vt;
                    Console.WriteLine("Valor a pagar é " + vp);
                    break;
                case 3:
                    vt = (vc * 5 / 100);
                    vp = vc - vt;
                    Console.WriteLine("Valor a pagar é " + vp);
                    vd = vp / 3;
                    Console.WriteLine("3 parcelas de " + vd);
                    break;
                case 4:
                    vt = vc;

                    Console.WriteLine("Valor a pagar é " + vt);
                    vd = vt / 6;
                    Console.WriteLine("6 parcelas de " + vd);
                    break;
                case 5:
                    vt = (vc * 8 / 100);
                    vp = vc + vt;
                    Console.WriteLine("Valor a pagar é " + vp);
                    vd = vp / 12;
                    Console.WriteLine("12 parcelas de " + vd);
                    break;

            }
            Console.ReadKey();
        }
    }
}
