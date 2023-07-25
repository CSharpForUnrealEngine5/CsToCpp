#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityWorldReticle_ActorVisualization.h")]
///<summary>This is a dummy reticle for internal use by visualization placement tasks. It builds a custom visual model of the visualization being placed.</summary>
public partial class AGameplayAbilityWorldReticle_ActorVisualization : AGameplayAbilityWorldReticle {
// GameplayAbilityWorldReticle_ActorVisualization
	public UCapsuleComponent CollisionComponent;
	public TArray<UActorComponent> VisualizationComponents;
}
