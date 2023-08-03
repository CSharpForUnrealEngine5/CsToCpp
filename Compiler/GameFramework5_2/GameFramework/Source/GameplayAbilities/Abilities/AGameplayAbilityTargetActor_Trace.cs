#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Intermediate base class for all line-trace type targeting actors.</summary>
[CppInclude("Abilities/GameplayAbilityTargetActor_Trace.h")]
public partial class AGameplayAbilityTargetActor_Trace : AGameplayAbilityTargetActor {
	public static UClass StaticClass() {return default;}
	///<summary>MaxRange</summary>
	public float MaxRange;
	///<summary>TraceProfile</summary>
	public FCollisionProfileName TraceProfile;
	///<summary>Does the trace affect the aiming pitch</summary>
	public bool bTraceAffectsAimPitch;
}
