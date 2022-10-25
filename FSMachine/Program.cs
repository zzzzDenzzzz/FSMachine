using FSMachine.DocumentFactory;
using System;

namespace FSMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var plan = new Plan(new DevelopmentDocumentState());
            plan.DocumentType();
            Console.WriteLine(plan.State);
            plan.Performed();
            Console.WriteLine(plan.State);
            plan.Performed();
            Console.WriteLine(plan.State);
            plan.Performed();
            Console.WriteLine(plan.State);
            plan.Performed();
            Console.WriteLine(plan.State);

            Console.WriteLine(new string('-', 35));

            var reference = new Reference(new DevelopmentDocumentState());
            reference.DocumentType();
            Console.WriteLine(reference.State);
            reference.Performed();
            Console.WriteLine(reference.State);
            reference.Performed();
            Console.WriteLine(reference.State);
            reference.Performed();
            Console.WriteLine(reference.State);
            reference.Performed();
            Console.WriteLine(reference.State);

            Console.WriteLine(new string('-', 35));

            var contract = new Contract(new DevelopmentDocumentState());
            contract.DocumentType();
            Console.WriteLine(contract.State);
            contract.Performed();
            Console.WriteLine(contract.State);
            contract.Performed();
            Console.WriteLine(contract.State);
            contract.Performed();
            Console.WriteLine(contract.State);
            contract.Performed();
            Console.WriteLine(contract.State);

            Console.WriteLine(new string('-', 35));

            Console.WriteLine();
        }
    }
}
