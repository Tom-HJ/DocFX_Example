using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocFX_Test
{
    /// <summary>
    /// [220117] (Tom-HJ) Process Program.
    /// </summary>
    /// <remarks>
    /// 프로그램 작동.
    /// </remarks>
    class Program
    {
        static void Main(string[] args)
        {
            Function.Instance.Test();
            Console.ReadLine();
        }
    }
}
