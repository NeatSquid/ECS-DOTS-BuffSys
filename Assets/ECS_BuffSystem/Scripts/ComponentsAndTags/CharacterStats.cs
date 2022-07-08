using Unity.Entities;

namespace TMG.StatBuffs
{
    [GenerateAuthoringComponent]
    public struct CharacterStats : IComponentData
    {
        public float AttackDamage;
        public float MoveSpeed;
    }
    
    public struct TotalAttackDamage : IComponentData
    {
        public float Value;
    }

    public struct TotalMoveSpeed : IComponentData
    {
        public float Value;
    }
}