namespace FSMachine.DocumentFactory
{
    internal class PlanDocumentCreate : IDocumentCreate
    {
        public IDocument Create(IDocumentState documentState)
        {
            return new Plan(documentState);
        }
    }
}
