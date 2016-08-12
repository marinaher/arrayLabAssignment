using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayLabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            playerStatistics playerStat = new playerStatistics();
            playerStat.runBaseballStatName();
            playerStat.CalcuatePercentage();
            Console.ReadLine();
        }
    }
}
