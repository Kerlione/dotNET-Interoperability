using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ThirdNumber
{
    public class CSharpThirdNumber
    {
        public static Int32 GetInt()
        {
            Console.Write("Please, enter the third number: ");
            var value = 0;
            value = Convert.ToInt32(Console.ReadLine());
            return value;
        }
    }
}
