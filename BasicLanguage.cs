using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_Sharp_Language_Basic
{

    class Basic
    {
        // Hello world   and Primitive type
     private   enum Types
        {
            Value,
            Referince
        }
        public void Hello()
        {

            Pointul pointul = new Pointul();
            pointul.x = 2;
            pointul.y = 3;
            Pointul p = pointul;
            p.x = 6;

            Console.WriteLine($"Hello World {p.x} * {p.y} = {p.x * p.y}");
            Console.WriteLine($"But because {pointul.x}*{pointul.y}={pointul.x * p.y} " +
                $"result that this is primitiv {Types.Value} Type ");

        }
     private   struct Pointul
        {
            // Initialization Denied
            public int x { get; set; }
            public int y;

        }

        public void RefType()
        {

            Point point = new Point();
            Point point2 = point;
            point2.x = 4;

            Console.WriteLine($"Because this is {Types.Referince} type " +
                $"{point.x}* {point.y}= {point.x * point.y}");

        }
        public void BoxingUnbixing()
        {
            int a = 6;
            object box = a;
            int b = (int)box;
            Console.WriteLine($"After Boxing/Unboxing {b}");

        }
        public void RefAndOut(int a,int b)
        {
            Console.WriteLine($"Initial values : {a}:{b} ");
            RefOut(ref a, out b);
            Console.WriteLine($"Post values :{a}:{b} ");

            Console.WriteLine($"Static Var is : {stVar}: accesed from Object");
            ChStatic(8);
            Console.WriteLine($"Static Var is : {stVar}:after change accesed from Object");

        }
        private void RefOut(ref int a,out  int b)
        {
            //Cant read Out {b} just to change
            b = a + 5;
            //Ref {a} Mast be initialized
            a += 5;
        
        }

        private static int stVar;
        //Static Methods can access only Static mebers
        private static void ChStatic(int a)
        {
            stVar = a;
        }
        public static void GetStaticVar()
        {

            Console.WriteLine($"Initial value is :{stVar} :+ 3");
            ChStatic(stVar + 3);
            Console.WriteLine($"Past value is :{stVar} :");
        }
        static Basic()
        {
            Console.WriteLine("Hello World !!!");
            ChStatic(4);
            Console.WriteLine($"Static Constructor Changed static var in :{stVar}:");
        }
        int rand = -1;
        public void Thread1()
        {
            rand += 1;
            for (int i = rand; i < 100+rand; i++)
            {
                Console.WriteLine($": {i} :");
                Thread.Sleep(100);
            }
        }



    }

    class Point
    {
      public int x = 3;
      public int y = 4;
    }







}
