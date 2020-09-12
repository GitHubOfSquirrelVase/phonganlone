using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fish();
            var c = new Cat("abc");
            var s = new Spider();
            //Console.WriteLine(d.Name);
            c.Name ="asdas";
            Console.WriteLine(c.Name);
            c.Walk(); 
            Console.WriteLine(c);
            //Console.WriteLine(a);
            //Console.WriteLine(e);
            //Console.WriteLine(p);
           // Console.WriteLine(("Legs:" + c.l());
            //d.Name("sds");
            //System.out.println("Name:" + d.getName());
            //d.play();
            //d.walk();
            //d.eat();

            //        System.out.println("Legs:"+c.getLegs());
            //        System.out.println("Name:"+c.getName());
            //        c.setName("Con meo");
            //        System.out.println("Name:"+c.getName());
            //        c.play();
            //        c.walk();
            //        c.eat();
            //        
            //        System.out.println("Legs:"+a.getLegs());
            //        a.walk();
            //        a.eat();
            //        
            //        System.out.println("Legs:"+e.getLegs());
            //        e.walk();
            //        e.eat();
            //        
            //        System.out.println(p.getName());
            //        p.setName("tiger");
            //        System.out.println(p.getName());
            //        p.play();
        }
    }
}
