using FSMachine.DocumentFactory;

namespace FSMachine.DocumentDecorator
{
    internal class ElectronicDocument : DocumentDecorator, IDocument
    {
        public ElectronicDocument(IDocumentState documentState, Document document) : base(documentState, document)
        {
        }

        public void DocumentType()
        {
            System.Console.WriteLine(typeof(ElectronicDocument).Name + " " + document.GetType());
        }
    }
}
