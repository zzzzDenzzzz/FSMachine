namespace FSMachine
{
    internal class Document
    {
        public IDocumentState State { get; set; }
        public Document(IDocumentState documentState)
        {
            State = documentState;
        }
        public void Performed() // выполнено
        {
            State.Performed(this);
        }
        public void Rejected() // отклонено
        {
            State.Rejected(this);
        }
    }
}
