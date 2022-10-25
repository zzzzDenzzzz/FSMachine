namespace FSMachine.DocumentFactory
{
    internal class ReferenceDocumentCreate : IDocumentCreate
    {
        public IDocument Create(IDocumentState documentState)
        {
            return new Reference(documentState);
        }
    }
}
