namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects everything within a given radius of the source actor.</summary>
[CppInclude("Abilities/GameplayAbilityTargetActor_Radius.h")]
public partial class AGameplayAbilityTargetActor_Radius : AGameplayAbilityTargetActor {
	public static UClass StaticClass() {return default;}
	///<summary>Radius of target acquisition around the ability&#39;s start location.</summary>
	public float Radius;
}
