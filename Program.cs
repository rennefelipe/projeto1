using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Numero_Chamado = 0;
            String Nome_Aluno = "Chirstian Perin";

            Numero_Chamado = 1;
            Console.WriteLine(Numero_Chamado);
            Console.WriteLine(Nome_Aluno);

            Console.WriteLine(args[0].ToString());
            Console.WriteLine(args[1].ToString());
            Console.WriteLine(args[2].ToString());
            Console.WriteLine(args[3].ToString());


            Console.WriteLine("Hello World!");
        }
    }
}

