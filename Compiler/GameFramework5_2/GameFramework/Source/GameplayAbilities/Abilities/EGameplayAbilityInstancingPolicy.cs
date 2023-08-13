namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>How the ability is instanced when executed. This limits what an ability can do in its implementation. For example, a NonInstanced</summary>
[CppEnumInNamespace]
public enum EGameplayAbilityInstancingPolicy {
	NonInstanced=0,
	InstancedPerActor=1,
	InstancedPerExecution=2,
}
