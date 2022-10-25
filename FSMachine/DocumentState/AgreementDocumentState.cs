using System;

namespace FSMachine
{
    internal class AgreementDocumentState : IDocumentState // согласование
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Отправлено на утверждение");
            document.State = new StatementDocumentState();
        }

        public void Rejected(Document document)
        {
            Console.WriteLine("Отправлено на проверку");
            document.State = new ExaminationDocumentState();
        }
    }
}
