using System;

namespace FSMachine
{
    internal class ExaminationDocumentState : IDocumentState // проверка
    {
        public void Performed(Document document)
        {
            Console.WriteLine($"Отправлено на согласование : {document.GetType().Name}");
            document.State = new AgreementDocumentState();
        }

        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
    }
}
