using UnityEngine;

namespace AttackSystem
{
    public class Attack1 : IAttackStrategy
    {
        public void Attack(Animator animator)
        {
            animator.SetTrigger("Attack1");
        }
    }
}
