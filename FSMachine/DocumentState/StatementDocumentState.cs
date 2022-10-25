using System;

namespace FSMachine
{
    internal class StatementDocumentState : IDocumentState // утверждение
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Отправлено на хранение");
            document.State = new StorageDocumentState();
        }

        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
    }
}
