namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Note that this behavior is supporting playing only a single montage for a</summary>
[CppInclude("GameplayBehavior_AnimationBased.h")]
public partial class UGameplayBehavior_AnimationBased : UGameplayBehavior {
	public static UClass StaticClass() {return default;}
	///<summary>OnMontageFinished</summary>
	public void OnMontageFinished(UAnimMontage Montage,bool bInterrupted,AActor InAvatar) {}
	///<summary>If this array ever gets more than couple elements at a time we should consider</summary>
	public TArray<FMontagePlaybackData> ActivePlayback;
}
