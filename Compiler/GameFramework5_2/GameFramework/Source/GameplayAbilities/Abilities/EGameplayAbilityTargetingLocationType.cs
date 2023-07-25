#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTargetTypes.h")]
///<summary>What type of location calculation to use when an ability asks for our transform</summary>
public enum EGameplayAbilityTargetingLocationType {
	LiteralTransform=0,
	ActorTransform=1,
	SocketTransform=2,
}
