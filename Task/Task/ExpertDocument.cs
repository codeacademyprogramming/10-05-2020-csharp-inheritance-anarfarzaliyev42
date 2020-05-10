using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class ExpertDocument : ProDocumentProgram
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in pdf format");
        }
    }
}
