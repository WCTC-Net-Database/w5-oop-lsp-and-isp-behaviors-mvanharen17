using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    public interface ICastable
    {
        void Cast(IEntity target, string spellName);
        string Name { get; set; }
        string spellName { get; set; }
    }
}
