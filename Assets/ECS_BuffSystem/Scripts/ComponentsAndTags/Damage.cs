using Unity.Entities;

namespace TMG.StatBuffs
{
    [GenerateAuthoringComponent]
    public struct Damage : IComponentData
    {
        public float Value;
    }
}