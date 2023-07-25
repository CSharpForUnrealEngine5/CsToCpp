#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehaviorConfig_Animation.h")]
public partial class UGameplayBehaviorConfig_Animation : UGameplayBehaviorConfig {
// GameplayBehaviorConfig_Animation
	public TSoftObjectPtr<UAnimMontage> AnimMontage;
	public float PlayRate;
	public string StartSectionName;
	public bool bLoop;
}
