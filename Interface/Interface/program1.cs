using System;

namespace Interface
{
    class program1 : IProgram, ISalvageable
    {
        public void start()
        {
            Console.WriteLine("Nu kör vi program 1");
        }

        public void Salvage()
        {
            Console.WriteLine("Salvaging parts");
        }
        //public void run()
        //{
        //    Console.WriteLine("Nu kör vi program 1");
        //}
    }
}
