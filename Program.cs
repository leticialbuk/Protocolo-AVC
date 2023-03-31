using System;

namespace ProtocoloAvc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Abrindo protocolo AVC");
            Console.WriteLine("---------------------");

            Console.Write("Nome do paciente: ");
            Console.ReadLine();

            Console.Write("Idade: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Número do protcolo: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("---------------------");
            Console.WriteLine("Iniciando protocolo AVC.....");
            Console.WriteLine("AVISO: Este protocolo deverá ser feito em 1 hora, risco iminente de morte!");

            //Console.WriteLine("Paciente foi encaminhado a sala de emergência? ");
        }


    }
}