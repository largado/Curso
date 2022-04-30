using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital vasconselos = new Hospital();

            vasconselos.paciente = "Doutor";

            vasconselos.Opera(10);

            Console.WriteLine(vasconselos.medico);
            Console.WriteLine(vasconselos.preco);
            Console.ReadKey();

        }
    }
}
