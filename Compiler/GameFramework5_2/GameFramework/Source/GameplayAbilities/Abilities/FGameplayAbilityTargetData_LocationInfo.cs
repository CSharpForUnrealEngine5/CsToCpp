#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Target data with just a source and target location in space</summary>
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
public partial struct FGameplayAbilityTargetData_LocationInfo {
	public FGameplayAbilityTargetingLocationInfo SourceLocation;
	public FGameplayAbilityTargetingLocationInfo TargetLocation;
}
