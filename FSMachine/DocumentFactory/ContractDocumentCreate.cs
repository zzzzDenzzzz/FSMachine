namespace FSMachine.DocumentFactory
{
    internal class ContractDocumentCreate : IDocumentCreate
    {
        public IDocument Create(IDocumentState documentState)
        {
            return new Contract(documentState);
        }
    }
}
