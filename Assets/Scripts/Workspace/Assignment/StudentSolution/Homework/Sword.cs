using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Sword : Weapon
    {
        public int bladeLength;

        public void Slash()
        {

        }
        public override void DealDamage(Entity target)
        {
            base.DealDamage(target);
        }
        public override void Use(Player player)
        {
            base.Use(player);
        }
    }
}
