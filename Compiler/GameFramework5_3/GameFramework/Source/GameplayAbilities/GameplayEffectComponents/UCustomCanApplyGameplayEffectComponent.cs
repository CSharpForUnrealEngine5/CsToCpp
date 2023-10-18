namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles configuration of a CustomApplicationRequirement function to see if this GameplayEffect should apply</summary>
[CppInclude("GameplayEffectComponents/CustomCanApplyGameplayEffectComponent.h")]
public partial class UCustomCanApplyGameplayEffectComponent : UGameplayEffectComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Custom application requirements</summary>
	public TArray<UClass> ApplicationRequirements;
}
