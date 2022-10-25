namespace FSMachine
{
    internal interface IDocumentState
    {
        void Performed(Document document); // выполнено
        void Rejected(Document document); // отклонено
    }
}
