#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayBehavior_AnimationBased.h")]
///<summary>Note that this behavior is supporting playing only a single montage for a</summary>
public partial class UGameplayBehavior_AnimationBased : UGameplayBehavior {
// GameplayBehavior_AnimationBased
	public  void OnMontageFinished(UAnimMontage Montage,bool bInterrupted,AActor InAvatar) {}
	public TArray<FMontagePlaybackData> ActivePlayback;
}
