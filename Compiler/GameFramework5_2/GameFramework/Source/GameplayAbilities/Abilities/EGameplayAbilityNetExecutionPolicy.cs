#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityTypes.h")]
///<summary>Where does an ability execute on the network. Does a client &quot;ask and predict&quot;, &quot;ask and wait&quot;, &quot;don&#39;t ask (just do it)&quot;</summary>
[CppEnumInNamespace]
public enum EGameplayAbilityNetExecutionPolicy {
	LocalPredicted=0,
	LocalOnly=1,
	ServerInitiated=2,
	ServerOnly=3,
}
