#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetActor_GroundTrace.h")]
public partial class AGameplayAbilityTargetActor_GroundTrace : AGameplayAbilityTargetActor_Trace {
	public static UClass StaticClass() {return default;}
	///<summary>Radius for a sphere or capsule.</summary>
	public float CollisionRadius;
	///<summary>Height for a capsule. Implicitly indicates a capsule is desired if this is greater than zero.</summary>
	public float CollisionHeight;
}
