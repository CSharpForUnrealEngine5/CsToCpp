#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Target data with a single hit result, data is packed into the hit result</summary>
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
public partial struct FGameplayAbilityTargetData_SingleTargetHit {
	public FHitResult HitResult;
	public bool bHitReplaced;
}
