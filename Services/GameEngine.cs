using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _archer;
        private readonly IEntity _mage; 

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity archer, IEntity mage)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _archer = archer;
            _mage = mage;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _archer.Name = "Archer";
            _mage.Name = "Mage";

            string spellName = "Fireball";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);
            ((Ghost) _ghost).Fly();
            
            _archer.Move();
            _archer.Attack(_mage);
            ((Archer) _archer).Shoot(_goblin);

            _mage.Move();
            _mage.Attack(_character);
            ((Mage)_mage).Cast(_goblin, spellName);
        }
    }
}
