using FSMachine.DocumentFactory;
using System;

namespace FSMachine
{
    internal class DevelopmentDocumentState : IDocumentState // разработка
    {
        public void Performed(Document document)
        {
            Console.WriteLine($"Отправлено на проверку : {document.GetType().Name}");
            document.State = new ExaminationDocumentState();
        }

        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
    }
}
