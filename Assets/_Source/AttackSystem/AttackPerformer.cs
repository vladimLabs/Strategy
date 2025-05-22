using UnityEngine;

namespace _Source.AttackSystem
{
    public class AttackPerformer 
    {
        private IAttackStrategy _attackStrategy;
        private Animator _animator;

        public AttackPerformer(Animator animator)
        {
            _animator = animator;
        }

        public void SetStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void PerformAttack()
        {
            if(_attackStrategy != null)
                _attackStrategy.Attack(_animator);
        }
    }
}