namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This is data that can be used to create an FGameplayAbilitySpec. Has some data that is only relevant when granted by a GameplayEffect</summary>
[CppInclude("GameplayAbilitySpec.h")]
public partial struct FGameplayAbilitySpecDef {
	public UClass Ability;
	public FScalableFloat LevelScalableFloat;
	public int InputID;
	public EGameplayEffectGrantedAbilityRemovePolicy RemovalPolicy;
	public TWeakObjectPtr<UObject> SourceObject;
	public FGameplayAbilitySpecHandle AssignedHandle;
}
