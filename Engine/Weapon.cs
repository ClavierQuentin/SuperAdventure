using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public int MinimunDamage { get; set; }
        public int MaximunDamage { get; set; }
        public Weapon(int id, string name, string namePlural, int minimunDamage, int maximunDamage):base(id, name, namePlural)
        {
            MinimunDamage = minimunDamage;
            MaximunDamage = maximunDamage;
        }
    }
}
