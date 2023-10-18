namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorConfig_Animation.h")]
public partial class UGameplayBehaviorConfig_Animation : UGameplayBehaviorConfig {
	public static UClass StaticClass() {return default;}
	///<summary>UPROPERTY(EditDefaultsOnly, Category = GameplayBehavior)</summary>
	public TSoftObjectPtr<UAnimMontage> AnimMontage;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>StartSectionName</summary>
	public FName StartSectionName;
	///<summary>bLoop</summary>
	public bool bLoop;
}
