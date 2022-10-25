namespace FSMachine
{
    internal class CanceledDocumentState : IDocumentState// аннулировано
    {
        public void Performed(Document document)
        {
        }

        public void Rejected(Document document)
        {
        }
    }
}
