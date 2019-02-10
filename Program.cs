using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Language_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Basic basic = new Basic();
            basic.Hello();
            basic.RefType();
            basic.BoxingUnbixing();
            basic.RefAndOut(4, 7);
            Basic.GetStaticVar();
            // basic.GetStaticVar(); methods Cant be Accesed form Object 
            Console.WriteLine("Inceputul Threadurilor");
            Thread thread = new Thread(basic.Thread1);
            thread.Start();
            Console.WriteLine("Inceputul Threadului 1:");
            thread = new Thread(basic.Thread1);
            thread.Start();
            Console.WriteLine("Inceputul Threadului 2:");
            Console.WriteLine("Inceputul ReadLine");
            Console.ReadLine();
            Console.WriteLine("Sfirsitul  ReadLine");

        }




    }
}
