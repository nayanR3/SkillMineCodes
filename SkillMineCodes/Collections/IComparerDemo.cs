using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Collections
{
    public class Player2
    {
        private string name;
        private int runs;
        public Player2(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public override string ToString()
        {
            return $"{name} -> {runs}";
        }
    }


    public class Check : IComparer
    {
        public int Compare(object x, object y)
        {
            Player2 p1 = (Player2)x;
            Player2 p4 = (Player2)y;
            if (p1.runs > p4.runs)
            {
                return 1;
            }
            else if (p1.runs < p4.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }


    public class Team2 : IEnumerable
    {
        private Player2[] players;
        public Team2()
        {
            players = new Player2[5];
            players[0] = new Player2("Rohit", 45);
            players[1] = new Player2("Virat", 80);
            players[2] = new Player2("Ishan", 79);
            players[3] = new Player2("Ashwin", 33);
            players[4] = new Player2("Hardik", 88);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Team2 team = new Team2();
            foreach (Player2 p in team)
            {
                Console.WriteLine(p);
            }

            Player2 players1 = new Player2("Rohit", 53);
            Player2 players2 = new Player2("Virat", 80);
            Player2 players3 = new Player2("Ishan", 79);
            Player2 players4 = new Player2("Ashwin", 53);
            Player2 players5 = new Player2("Hardik", 88);

            int result = players1.Compare(players4);

            if (result == 1)
            {
                Console.WriteLine("rohit has more runs than ashwin");
            }
            else if (result == -1)
            {
                Console.WriteLine("rohit has less runs than ashwin");
            }
            else
            {
                Console.WriteLine("rohit & ashwin has same score");
            }
        }
    }
}
