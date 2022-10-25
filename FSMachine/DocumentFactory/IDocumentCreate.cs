namespace FSMachine.DocumentFactory
{
    internal interface IDocumentCreate
    {
        IDocument Create(IDocumentState documentState);
    }
}
