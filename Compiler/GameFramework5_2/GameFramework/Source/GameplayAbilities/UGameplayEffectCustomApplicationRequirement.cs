namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class used to perform custom gameplay effect modifier calculations, either via blueprint or native code</summary>
[CppInclude("GameplayEffectCustomApplicationRequirement.h")]
public partial class UGameplayEffectCustomApplicationRequirement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Return whether the gameplay effect should be applied or not</summary>
	public bool CanApplyGameplayEffect(UGameplayEffect GameplayEffect,FGameplayEffectSpec Spec,UAbilitySystemComponent ASC) { return default; }
}
