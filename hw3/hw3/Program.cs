using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    public class Player
    {
        public int _id;
        public string _nickname;
        public int _lvl;
        public bool _isBanned;

        public Player(int id, string name, int lvl)
        {
            _isBanned = false;
            _id = id;
            _lvl = lvl;
            _nickname = name;
        }


    }

    class Program
    {
        public static List<Player> Archive = new List<Player>();

        private static int _nextId = 1;
        private static string _inputedString;
        private static int _inputedLvl;
        private static int _selectedOption;
        static void Main(string[] args)
        {
            //_selectedOption = Console.Read();
            while(Console.Read() != 0)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("1 - Add new player");
                Console.WriteLine("2 - Select Player");
                Console.WriteLine("0 - End");
                _selectedOption = Console.Read();

                if (Console.Read() == 1)
                {
                    Console.WriteLine("Write his nickname");
                    _inputedString = Console.ReadLine();
                    Console.WriteLine("Write his lvl");
                    _inputedLvl = Console.Read();
                    Player added = new Player(_nextId, _inputedString, _inputedLvl);
                    _nextId++;
                    Archive.Add(added);
                }
                else if (Console.Read() == 2)
                {
                    Console.WriteLine("List of players");
                    foreach (Player some in Archive)
                    {
                        Console.WriteLine(some._id);
                        Console.WriteLine(some._nickname);
                        Console.WriteLine(some._lvl);
                        Console.WriteLine(some._isBanned);
                        Console.WriteLine("______________________");
                    }

                    Console.WriteLine("Do you want to ban/unban players?");
                    Console.WriteLine("1 - yes");
                    Console.WriteLine("2 - no");
                    _selectedOption = Console.Read();

                    if (Console.Read() == 1)
                    {
                        Console.WriteLine("which player?");
                        _selectedOption = Console.Read();
                        foreach (Player some in Archive)
                        {
                            if (some._id == _selectedOption)
                            {
                                some._isBanned = !some._isBanned;
                            }
                        }
                    }
                    else return;
                }
                else return;
            }
            Player first = new Player(_nextId,_inputedString,_inputedLvl);
        }
              
    }
         
 }

            
    


