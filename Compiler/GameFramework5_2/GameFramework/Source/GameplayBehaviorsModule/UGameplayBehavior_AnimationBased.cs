#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note that this behavior is supporting playing only a single montage for a</summary>
[CppInclude("GameplayBehavior_AnimationBased.h")]
public partial class UGameplayBehavior_AnimationBased : UGameplayBehavior {
	///<summary>OnMontageFinished</summary>
	public  void OnMontageFinished(UAnimMontage Montage,bool bInterrupted,AActor InAvatar) {}
	///<summary>If this array ever gets more than couple elements at a time we should consider</summary>
	public TArray<FMontagePlaybackData> ActivePlayback;
}
