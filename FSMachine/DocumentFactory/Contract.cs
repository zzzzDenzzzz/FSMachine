using System;

namespace FSMachine.DocumentFactory
{
    internal class Contract : Document, IDocument
    {
        public Contract(IDocumentState documentState) : base(documentState)
        {
        }

        public void DocumentType()
        {
            Console.WriteLine(typeof(Contract).Name);
        }
    }
}
