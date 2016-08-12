using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayLabAssignment
{
    public class PlayerStatistics
    {
        public string[] baseballStatNames;
        public double[] playerStats;
        double slugPercentage;

        public PlayerStatistics()
        {
            baseballStatNames = new string[] { "Singles", "Doubles", "Triples", "Home run", "At Bats", "Total Bases" };
            playerStats = new double[6];
        }
        public void RunBaseballStatName()
        {
            for (int i = 0; i < baseballStatNames.Length; i++)
            {
                Console.WriteLine("Player statistics for {0}: ", baseballStatNames[i]);
                playerStats[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void CalcuatePercentage()
        {
            slugPercentage = (playerStats[5] / playerStats[4] * 100);
            Console.WriteLine("Total Slugging percentage: " + Convert.ToInt32(Convert.ToDouble(slugPercentage)) + "%");
            Console.ReadLine();
        }
    }
}