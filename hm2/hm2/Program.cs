using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm2
{
   public class Player
    {
        public int PosX ;
        public int PosY ;

        public Player(int posX , int posY)
        {
            PosX = posX;
            PosY = posY;
        }
    }
    public class ConsoleDrawer
    {
        public void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player first = new Player(2, 4);
            ConsoleDrawer drawer = new ConsoleDrawer();
            drawer.Draw(first.PosX, first.PosY);
            Console.ReadKey();
        }
    }
}
