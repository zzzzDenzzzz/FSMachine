namespace FSMachine.DocumentDecorator
{
    abstract class DocumentDecorator : Document
    {
        protected Document document;

        public DocumentDecorator(IDocumentState documentState, Document document) : base(documentState)
        {
            this.document = document;
        }
    }
}
