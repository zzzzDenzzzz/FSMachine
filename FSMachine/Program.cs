using System;

/// <summary>
/// 
/// ПРИМЕНИЛ ПАТТЕРН State
/// 
/// </summary>

namespace FSMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document(new DevelopmentDocumentState());
            string input = Console.ReadLine();
            if (input == "0")
            {
                document.Performed();
                _ = new Document(new ExaminationDocumentState());
            }
            else if (input == "1")
            {
                document.Rejected();
                _ = new Document(new CanceledDocumentState());
            }
            else if (input == "2")
            {
                document.Correction();
                _ = new Document(new CanceledDocumentState());
            }

            input = Console.ReadLine();
            if (input == "0")
            {
                document.Performed();
                _ = new Document(new AgreementDocumentState());
            }
            else if (input == "1")
            {
                document.Rejected();
                _ = new Document(new CanceledDocumentState());
            }
            else if (input == "2")
            {
                document.Correction();
                _ = new Document(new DevelopmentDocumentState());
            }

            input = Console.ReadLine();
            if (input == "0")
            {
                document.Performed();
                _ = new Document(new StatementDocumentState());
            }
            else if (input == "1")
            {
                document.Rejected();
                _ = new Document(new AgreementDocumentState());
            }
            else if (input == "2")
            {
                document.Correction();
                _ = new Document(new DevelopmentDocumentState());
            }

            input = Console.ReadLine();
            if (input == "0")
            {
                document.Performed();
                _ = new Document(new StorageDocumentState());
            }
            else if (input == "1")
            {
                document.Rejected();
                _ = new Document(new CanceledDocumentState());
            }
            else if (input == "2")
            {
                document.Correction();
                _ = new Document(new DevelopmentDocumentState());
            }
        }
    }
    class Document
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
        public void Correction() // исправление
        {
            State.Correction(this);
        }
    }
    interface IDocumentState
    {
        void Performed(Document document); // выполнено
        void Rejected(Document document); // отклонено
        void Correction(Document document); // исправление
    }
    class DevelopmentDocumentState : IDocumentState // разработка
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Проверка");
            document.State = new ExaminationDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
    }
    class ExaminationDocumentState : IDocumentState // проверка
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Согласование");
            document.State = new AgreementDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Разработка");
            document.State = new DevelopmentDocumentState();
        }
    }
    class AgreementDocumentState : IDocumentState // согласование
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Утверждение");
            document.State = new StatementDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Согласование");
            document.State = new AgreementDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Разработка");
            document.State = new DevelopmentDocumentState();
        }
    }
    class StatementDocumentState : IDocumentState // утверждение
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Хранение");
            document.State = new StorageDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Разработка");
            document.State = new DevelopmentDocumentState();
        }
    }
    class CanceledDocumentState : IDocumentState // аннулировано
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Аннулированно");
            document.State = new CanceledDocumentState();
        }
    }
    class StorageDocumentState : IDocumentState // хранение
    {
        public void Performed(Document document)
        {
            Console.WriteLine("Хранение");
            document.State = new StorageDocumentState();
        }
        public void Rejected(Document document)
        {
            Console.WriteLine("Хранение");
            document.State = new StorageDocumentState();
        }
        public void Correction(Document document)
        {
            Console.WriteLine("Хранение");
            document.State = new StorageDocumentState();
        }
    }
}
