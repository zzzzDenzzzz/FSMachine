using System;

namespace FSMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document(new DevelopmentDocumentState());

            Console.WriteLine();
        }
    }
}
