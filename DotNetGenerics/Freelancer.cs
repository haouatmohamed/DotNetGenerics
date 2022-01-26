namespace DotNetGenerics
{
    internal sealed class Freelancer
    {
        public Freelancer(string name, double salary, Team team)
        {
            Name = name;
            Salary = salary;
            Team = team;
        }

        public string Name { get; }
        public double Salary { get; }
        public Team Team { get; }
    }
}
