using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaKatia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração em instanciação dos objetos
            Aluno al= new Aluno();
            Mensalidade men = new Mensalidade();
            //chamada dos métodos
            Console.Write("Digite o nome: ");
            al.SetNome(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            al.SetEndereco(Console.ReadLine());
            Console.Write("Digite o Cpf: ");
            al.SetCpf(Console.ReadLine());
            Console.Write("Digite o RA: ");
            al.SetRa(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Digite o curso: ");
            men.SetCurso(Console.ReadLine());
            Console.Write("Digite o vaçor: ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o dia do pagamento: ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nDados do Aluno");
            Console.WriteLine("RA: " + al.GetRa() + "\nAluno: " + al.GetNome());
            Console.WriteLine("Endereço: " + al.GetEndereco() + "\nCPF: " + al.GetCpf());
            Console.WriteLine("Cuso: " +men.GetCurso() + "\nValor da Mensalidade: " + men.GetValor().ToString("C")+"\nValor a pagar: "+men.Calcular().ToString("C"));

        }
    }
}
