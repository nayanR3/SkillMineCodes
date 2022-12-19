using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Collections
{
    public class Player1 : IComparable
    {
        private string name;
        private int runs;
        public Player1(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public int CompareTo(object obj)// obj=player4
        {
            Player1 p4 = (Player1)obj;  // type casting
            // to access runs of palyer1 we use this
            // this--> point to the current object
            if (this.runs > p4.runs)
            {
                return 1;
            }
            else if (this.runs < p4.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} -> {runs}";
        }
    }



    public class Team1 : IEnumerable
    {
        private Player1[] players;
        public Team1()
        {
            players = new Player1[5];
            players[0] = new Player1("Rohit", 45);
            players[1] = new Player1("Virat", 80);
            players[2] = new Player1("Ishan", 79);
            players[3] = new Player1("Ashwin", 33);
            players[4] = new Player1("Hardik", 88);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class Program1
    {
        static void Main(string[] args)
        {
            Team1 team = new Team1();
            foreach (Player1 p in team)
            {
                Console.WriteLine(p);
            }

            Player1 players1 = new Player1("Rohit", 53);
            Player1 players2 = new Player1("Virat", 80);
            Player1 players3 = new Player1("Ishan", 79);
            Player1 players4 = new Player1("Ashwin", 53);
            Player1 players5 = new Player1("Hardik", 88);

            int result = players1.CompareTo(players4);

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
