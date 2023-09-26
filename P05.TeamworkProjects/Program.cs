using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++) 
            {
                bool existing = false;
                string[] input= Console.ReadLine().Split("-");
                for (int j = 0; j < teams.Count; j++)
                {
                    if (input[1] == teams[j].Name)
                    {
                        Console.WriteLine($"Team {teams[j].Name} was already created!");
                        existing = true;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                for (int m = 0; m < teams.Count; m++)
                {
                    if (input[0] == teams[m].Creator)
                    {
                        Console.WriteLine($"{teams[m].Creator} cannot create another team!");
                        existing = true;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (existing) { continue; }
                else
                {
                    Team team = new Team();
                    team.NameParticipants = new List<string>();
                    team.Creator = input[0];
                    team.Name = input[1];
                    teams.Add(team);
                    Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
                }
            }
            string[] inputJoining = Console.ReadLine().Split("->");
            while (inputJoining[0] != "end of assignment") //
            {
                bool nameExisting = false;
                bool creatorExisting = false;
                bool memberNameExisting = false;
                for (int i = 0; i < teams.Count; i++)
                {
                    if (inputJoining[1] == teams[i].Name)
                    {
                        nameExisting = true;
                        if (inputJoining[0] != teams[i].Creator)
                        {
                            creatorExisting = true;
                            if (teams[i].NameParticipants.Contains(inputJoining[0]) == false)
                            {
                            teams[i].NameParticipants.Add(inputJoining[0]);
                                memberNameExisting = true;
                                break;
                            }
                        }
                    }
                }
                if (!nameExisting) { Console.WriteLine($"Team {inputJoining[1]} does not exist!"); }
                else if (!creatorExisting || !memberNameExisting)
                {
                    Console.WriteLine($"Member {inputJoining[0]} cannot join team {inputJoining[1]}!");
                }
                inputJoining = Console.ReadLine().Split("->");
            }// Влизане на хора във вече същестуващи отбори + проверки за това
            Print(teams);
        }
        static void Print(List<Team> teams)
        {
            List<Team> disbanded = new List<Team>();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].NameParticipants.Count == 0)
                {
                    disbanded.Add(teams[i]);
                    teams.RemoveAt(i);
                }
            }



            foreach (var item in teams.OrderByDescending(x => x.NameParticipants.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"- {item.Creator}");

                foreach (var member in item.NameParticipants.OrderBy(x => x))
                {
                Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbanded.OrderBy(x => x.Name)) 
            {
                Console.WriteLine($"{team.Name}");
            }
        }
        public class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> NameParticipants { get; set; }
        }
    }
}
