#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>How an ability replicates state/events to everyone on the network</summary>
[CppEnumInNamespace]
public enum EGameplayAbilityReplicationPolicy {
	ReplicateNo=0,
	ReplicateYes=1,
}
