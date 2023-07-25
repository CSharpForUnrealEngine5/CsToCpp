#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Where does an ability execute on the network. Does a client "ask and predict", "ask and wait", "don't ask (just do it)"</summary>
[CppEnumInNamespace]
public enum EGameplayAbilityNetExecutionPolicy {
	LocalPredicted=0,
	LocalOnly=1,
	ServerInitiated=2,
	ServerOnly=3,
}
