using System;

namespace FSMachine.DocumentFactory
{
    internal class Reference : Document, IDocument
    {
        public Reference(IDocumentState documentState) : base(documentState)
        {
        }

        public void DocumentType()
        {
            Console.WriteLine(typeof(Reference).Name);
        }
    }
}
