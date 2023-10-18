namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>What protections does this ability have? Should the client be allowed to request changes to the execution of the ability?</summary>
[CppEnumInNamespace]
public enum EGameplayAbilityNetSecurityPolicy {
	ClientOrServer=0,
	ServerOnlyExecution=1,
	ServerOnlyTermination=2,
	ServerOnly=3,
}
