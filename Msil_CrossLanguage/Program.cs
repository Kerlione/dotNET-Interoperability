using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msil_CrossLanguage
{
    class Program
    {
        static void Main(string[] args)
        {
            VB.Library.Program vbProgram = new VB.Library.Program();
            vbProgram.Hello();
            
            Console.WriteLine("Hello from C#");
            Console.ReadLine();
        }
    }
}
