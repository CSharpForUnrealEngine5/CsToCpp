#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayAbilitySpec.h")]
///<summary>This is data that can be used to create an FGameplayAbilitySpec. Has some data that is only relevant when granted by a GameplayEffect</summary>
public partial struct FGameplayAbilitySpecDef {
// GameplayAbilitySpecDef
	public UClass Ability;
	public FScalableFloat LevelScalableFloat;
	public int InputID;
	public EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy;
	public TWeakObjectPtr<UObject> SourceObject;
	public FGameplayAbilitySpecHandle AssignedHandle;
}
