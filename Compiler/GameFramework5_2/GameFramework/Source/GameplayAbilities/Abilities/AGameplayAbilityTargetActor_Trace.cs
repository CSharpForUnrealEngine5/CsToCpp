#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetActor_Trace.h")]
///<summary>Intermediate base class for all line-trace type targeting actors.</summary>
public partial class AGameplayAbilityTargetActor_Trace : AGameplayAbilityTargetActor {
// GameplayAbilityTargetActor_Trace
	public float MaxRange;
	public FCollisionProfileName TraceProfile;
	public bool bTraceAffectsAimPitch;
}
