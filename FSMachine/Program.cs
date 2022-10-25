using FSMachine.DocumentDecorator;
using FSMachine.DocumentFactory;
using System;

namespace FSMachine
{
    class Program
    {
        public static void PrintLine() => Console.WriteLine(new string('-', 35));

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

            PrintLine();

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

            PrintLine();

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

            PrintLine();

            var electronicContract = new ElectronicDocument(new DevelopmentDocumentState(), contract);
            electronicContract.DocumentType();
            Console.WriteLine(electronicContract.State);
            electronicContract.Performed();
            Console.WriteLine(electronicContract.State);
            electronicContract.Performed();
            Console.WriteLine(electronicContract.State);
            electronicContract.Performed();
            Console.WriteLine(electronicContract.State);
            electronicContract.Performed();
            Console.WriteLine(electronicContract.State);

            PrintLine();

            Console.WriteLine();
        }
    }
}
