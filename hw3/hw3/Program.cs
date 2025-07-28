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
    public class DataBase
    {
        public static List<Player> Archive = new List<Player>();
    }
    class Program
    {
        static int _nextId = 1;
        
        static private void DisplayMenu()
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1 - Add new player");
            Console.WriteLine("2 - Select Player");
            Console.WriteLine("0 - End");
            string line = Console.ReadLine();
            int _selectedOption = Convert.ToInt32(line);
            while (line != "0")
            {
                switch (_selectedOption)
                {
                    case 1:
                        {
                            FirstOption();
                            DisplayMenu();
                        }
                        break;

                    case 2:
                        {
                            SecondOption();
                            DisplayMenu();
                        }
                        break;
                }
            }
        }

        static private void FirstOption()
        {
            Console.WriteLine("Write his nickname");
            string _inputedString = Console.ReadLine();
            Console.WriteLine("Write his lvl");
            string line = Console.ReadLine();
            int _inputedLvl = Convert.ToInt32(line);
            Player added = new Player(_nextId, _inputedString, _inputedLvl);
            _nextId++;
            DataBase.Archive.Add(added);            
        }

        static private void SecondOption()
        {
            Console.WriteLine("List of players");
            foreach (Player var in DataBase.Archive)
            {
                Console.WriteLine("id "+ var._id);
                Console.WriteLine("nickname " + var._nickname);
                Console.WriteLine("lvl " + var._lvl);
                Console.WriteLine("Is banned " + var._isBanned);
                Console.WriteLine("______________________");
            }
            Console.WriteLine("Do you want to ban/unban players?");
            Console.WriteLine("1 - yes");
            Console.WriteLine("2 - no");
            SelectPlayer();            
        }

        static private void SelectPlayer()
        {
            string line = Console.ReadLine();
            int option = Convert.ToInt32(line);
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("which player?");
                        string anotherLine = Console.ReadLine();
                        int selectedPlayer = Convert.ToInt32(anotherLine);
                        foreach (Player var in DataBase.Archive)
                        {
                            if (var._id == selectedPlayer)
                            {
                                var._isBanned = !var._isBanned;
                            }
                        }
                    }
                    break;                 
            }
        }

        static void Main(string[] args)
        {   
            DisplayMenu();        
        }              
    }
         
 }

            
    


