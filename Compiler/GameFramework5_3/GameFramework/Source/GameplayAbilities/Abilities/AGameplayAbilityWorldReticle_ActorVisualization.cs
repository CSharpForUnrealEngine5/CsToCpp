namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is a dummy reticle for internal use by visualization placement tasks. It builds a custom visual model of the visualization being placed.</summary>
[CppInclude("Abilities/GameplayAbilityWorldReticle_ActorVisualization.h")]
public partial class AGameplayAbilityWorldReticle_ActorVisualization : AGameplayAbilityWorldReticle {
	public static UClass StaticClass() {return default;}
	///<summary>Hardcoded collision component, so other objects don&#39;t think they can collide with the visualization actor</summary>
	public UCapsuleComponent CollisionComponent;
	///<summary>VisualizationComponents</summary>
	public TArray<UActorComponent> VisualizationComponents;
}
