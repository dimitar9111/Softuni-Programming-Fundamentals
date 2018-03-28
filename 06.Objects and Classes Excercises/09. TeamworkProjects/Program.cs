using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    public class Program
    {
        public static void Main()
        {
            var teamInfo = new List<Team>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');

                var newTeam = new Team()
                {
                    Creator = input[0],
                    Name = input[1],
                    Members = new List<string>()
                };

                if (teamInfo.Any(x => x.Name == input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
                else if (teamInfo.Any(x => x.Creator == input[0]))
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                    teamInfo.Add(newTeam);
                }
            }

            var secondInput = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            while (secondInput[0] != "end of assignment")
            {
                if (teamInfo.All(k => k.Name != secondInput[1]))
                {
                    Console.WriteLine($"Team {secondInput[1]} does not exist!");
                }

                else if (teamInfo.Any(x => x.Creator == secondInput[0]) || teamInfo.Any(x => x.Members.Contains(secondInput[0])))
                {
                    Console.WriteLine($"Member {secondInput[0]} cannot join team {secondInput[1]}!");
                }

                else
                {
                    teamInfo.First(x => x.Name == secondInput[1]).Members.Add(secondInput[0]);
                }

                secondInput = Console.ReadLine().Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            var validTeams = teamInfo.Where(x => x.Members.Count > 0).ToList();
            var unValidTeams = teamInfo.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in unValidTeams.OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
