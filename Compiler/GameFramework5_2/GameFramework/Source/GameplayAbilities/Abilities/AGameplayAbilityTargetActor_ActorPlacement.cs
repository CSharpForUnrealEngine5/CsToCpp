#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetActor_ActorPlacement.h")]
public partial class AGameplayAbilityTargetActor_ActorPlacement : AGameplayAbilityTargetActor_GroundTrace {
	public static UClass StaticClass() {return default;}
	///<summary>Actor we intend to place.</summary>
	public UClass PlacedActorClass;
	///<summary>Override Material 0 on our placed actor&#39;s meshes with this material for visualization.</summary>
	public UMaterialInterface PlacedActorMaterial;
}
