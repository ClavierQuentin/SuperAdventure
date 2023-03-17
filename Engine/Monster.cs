using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public int MaximunDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem>LootTable { get; set; }
        public Monster( int id, string name, int maximunDamage, int rewardExperiencePoints, int rewardGold, int maxHitPoints, int currentHitPoints) : base(maxHitPoints, currentHitPoints)
        {
            ID = id;
            Name = name;
            MaximunDamage = maximunDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
