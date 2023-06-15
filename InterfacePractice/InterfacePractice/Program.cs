using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacePractice
{
    public interface Ieat
    {
        void eat();
    }
    public interface Isleep
    {
        void sleep();
    }
    public interface Ifly
    {
        void fly();
    }
    public interface Iswim
    {
        void swim();
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Bird bird = new Bird();

        }
    }
}
