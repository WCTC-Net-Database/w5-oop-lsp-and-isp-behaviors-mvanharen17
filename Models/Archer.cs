using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Archer : IEntity, IShootable
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"{Name} hits {target.Name} with their bow");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} moves swiftly.");
        }

        public void Shoot(IEntity target)
        {
            Console.WriteLine($"{Name} shoots {target.Name} right in the knee");
        }
    }

}
