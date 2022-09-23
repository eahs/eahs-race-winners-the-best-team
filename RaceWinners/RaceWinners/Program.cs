using System;
using System.Linq;
using System.Threading.Tasks;

namespace RaceWinners
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DataService ds = new DataService();
 
            // Asynchronously retrieve the group (class) data
            var groups = await ds.GetGroupRanksAsync();

            //var sorted = groups.OrderBy(group => group.Ranks.Average()).ToList();
     
            for (int i = 0; i < groups.Count; i++)
            {
                groups[i].Score = groups[i].Ranks.Average();
                var group = groups[i];
                
                var ranks = String.Join(", ", groups[i].Ranks);
                
                
            }

            var sorted = groups.OrderBy(group => group.Score).ToList();
            for (int j = 0; j < sorted.Count; j++)
            {
                Console.WriteLine($"{sorted[j].Name} - {j + 1} - average speed {sorted[j].Score}");
            }
            {
                
            }
        }
    }
}