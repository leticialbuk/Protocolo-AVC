using System;

namespace ProtocoloAvc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("TRIAGEM");
            Console.WriteLine("-------");

            Console.Write("Nome do paciente: ");
            Console.ReadLine();

            Console.Write("Idade: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Número do protcolo: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("O paciente será encaminhado a emergência.");

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
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Foi pulsionado acesso venoso no paciente? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("O paciente será encaminhado para coleta de sangue.");
                    ContinuidadeAtendimentoEtapa2();
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("Deve ser feito acesso venoso no paciente para darmos continuidade ao atendimento!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }

        public static void ContinuidadeAtendimentoEtapa2()
        {
            string acessoVenoso;
            do
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Foi realizada a coleta de sangue do paciente? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("O paciente será encaminhado para fazer ECG");
                    ContinuidadeAtendimentoEtapa3();
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("É necessário ter a coleta de sangue para darmos continuidade ao atendimento");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }

        public static void ContinuidadeAtendimentoEtapa3()
        {
            string acessoVenoso;
            do
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("O paciente realizou o eletrocardiograma? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("Daremos continuidade ao atendimento, o paciente será encaminhado para realizar uma tomografia");
                    ContinuidadeAtendimentoEtapa4();
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("É necessário o ECG para darmos continuidade ao atendimento!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }

        public static void ContinuidadeAtendimentoEtapa4()
        {
            string acessoVenoso;
            do
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("O paciente realizou a tomografia? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("Daremos continuidade ao atendimento...");
                    ContinuidadeAtendimentoEtapa5();
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("É necessário a tomografia para darmos continuidade ao atendimento!");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }

        public static void ContinuidadeAtendimentoEtapa5()
        {
            string acessoVenoso;
            do
            {
                Console.WriteLine("--------------------------------------------------------------------------------------------");
                Console.WriteLine("Com base no laudo da tomografia, é necessário ser feito a trombólise no paciente? sim ou nao");
                acessoVenoso = Console.ReadLine();

                if (acessoVenoso.ToLower() == "sim")
                {
                    Console.WriteLine("O paciente será submetido a trombólise, após o procedimento ficará em observação");
                }
                else if (acessoVenoso.ToLower() == "nao")
                {
                    Console.WriteLine("O paciente ficará em observção na UTI");
                }
                else
                {
                    Console.WriteLine("Resposta inválida");
                }
            } while (acessoVenoso.ToLower() != "sim" && acessoVenoso.ToLower() != "nao");
        }
    }
}