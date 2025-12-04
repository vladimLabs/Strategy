using UnityEngine;

namespace AttackSystem
{
    public interface IAttackStrategy
    {
        public void Attack(Animator animator);
    }
}