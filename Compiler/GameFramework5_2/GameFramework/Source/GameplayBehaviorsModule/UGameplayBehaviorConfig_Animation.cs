#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorConfig_Animation.h")]
public partial class UGameplayBehaviorConfig_Animation : UGameplayBehaviorConfig {
	///<summary>UPROPERTY(EditDefaultsOnly, Category = GameplayBehavior)</summary>
	public TSoftObjectPtr<UAnimMontage> AnimMontage;
	///<summary>PlayRate</summary>
	public float PlayRate;
	///<summary>StartSectionName</summary>
	public string StartSectionName;
	///<summary>bLoop</summary>
	public bool bLoop;
}
