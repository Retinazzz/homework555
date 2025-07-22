using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm2
{
   public class Player
    {
        public int _posX ;
        public int _posY ;
        public Player(int posX , int posY)
        {
            _posX = posX;
            _posY = posY;
        }
    }
    public class OtrisovLLl1k
    {
        public void Otr1sovka(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("@");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Player playa1 = new Player(2, 4);
            OtrisovLLl1k drawer = new OtrisovLLl1k();
            drawer.Otr1sovka(playa1._posX, playa1._posY);
            Console.ReadKey();
        }
    }
}
