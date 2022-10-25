using System;

namespace FSMachine.DocumentFactory
{
    internal class Plan : Document, IDocument
    {
        public Plan(IDocumentState documentState) : base(documentState)
        {
        }

        public void DocumentType()
        {
            Console.WriteLine(typeof(Plan).Name);
        }
    }
}
