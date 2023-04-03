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
            Console.WriteLine("--------------------------------------------------------------------------");

            string entradaEmergencia;
            do
            {
                Console.WriteLine("O paciente deu entrada na emergência? sim ou nao");
                entradaEmergencia = Console.ReadLine();

                if (entradaEmergencia.ToLower() == "sim")
                {
                    Console.WriteLine("Daremos continuidade ao atendimento...");
                    ContinuidadeAtendimentoEtapa1();
                }
                else if (entradaEmergencia.ToLower() == "nao")
                {
                    Console.WriteLine("O paciente deve ser encaminhado a emergência!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (entradaEmergencia.ToLower() != "sim" && entradaEmergencia.ToLower() != "nao");

        }

        public static void ContinuidadeAtendimentoEtapa1()
        {
            string acessoVenoso;
            do
            {
                Console.WriteLine("Foi pulsionado acesso venoso no paciente? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("Daremos continuidade ao atendimento...");
                    // ContinuidadeAtendimentoEtapa2();
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("Deve ser feito acesso venoso no paciente para darmos continuidade ao aendimento!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }

    }
}