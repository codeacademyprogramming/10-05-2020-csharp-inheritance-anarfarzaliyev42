using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInputs();

            Console.ReadKey();
        }
        static void GetInputs()
        {
            Console.WriteLine("Please enter keyword");
            string keyWord = Console.ReadLine();

            CheckKeyword(keyWord);
        }
        static void CheckKeyword(string keyWord)
        {
            DocumentProgram documentProgram;
            switch (keyWord)
            {
                case "basic":
                    documentProgram = new DocumentProgram();
                    break;
                case "pro":
                    documentProgram = new ProDocumentProgram();
                    break;
                case "expert":
                    documentProgram = new ExpertDocument();
                    break;
                default:
                    Console.WriteLine("Invalid Keyword");
                    return;

            }
            ShowOperations(documentProgram);

        }
        static void ShowOperations(DocumentProgram documentProgram)
        {
            documentProgram.OpenDocument();
            documentProgram.EditDocument();
            documentProgram.SaveDocument();
        }
    }

}
