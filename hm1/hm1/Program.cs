using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm1
{
    class Player
    {
        private string _someInfo;
        private string _name;
        private int _age;
        public Player(string info, string name)
        {
            _someInfo = info;
            _name = name;
            _age = 333;
        }
        public void ShowInfo()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_someInfo);
            Console.WriteLine(_age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player first = new Player("perviy","Gosshhhaaaaa");
            first.ShowInfo();
            Console.ReadKey();
        }
    }
}
