namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specifies tag requirements that the Target (owner of the Gameplay Effect) must have if this GE should apply or continue to execute</summary>
[CppInclude("GameplayEffectComponents/TargetTagRequirementsGameplayEffectComponent.h")]
public partial class UTargetTagRequirementsGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Tag requirements for this GameplayEffect to be applied to a target. This is pass/fail at the time of application. If fail, this GE fails to apply.</summary>
	public FGameplayTagRequirements ApplicationTagRequirements;
	///<summary>Once Applied, these tags requirements are used to determined if the GameplayEffect is &quot;on&quot; or &quot;off&quot;. A GameplayEffect can be off and do nothing, but still applied.</summary>
	public FGameplayTagRequirements OngoingTagRequirements;
	///<summary>Tag requirements that if met will remove this effect. Also prevents effect application.</summary>
	public FGameplayTagRequirements RemovalTagRequirements;
}
