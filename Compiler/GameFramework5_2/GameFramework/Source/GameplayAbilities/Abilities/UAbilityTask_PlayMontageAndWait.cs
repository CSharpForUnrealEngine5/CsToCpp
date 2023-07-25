#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/Tasks/AbilityTask_PlayMontageAndWait.h")]
///<summary>Ability task to simply play a montage. Many games will want to make a modified version of this task that looks for game-specific events</summary>
public partial class UAbilityTask_PlayMontageAndWait : UAbilityTask {
// AbilityTask_PlayMontageAndWait
	public FMontageWaitSimpleDelegate OnCompleted;
	public FMontageWaitSimpleDelegate OnBlendOut;
	public FMontageWaitSimpleDelegate OnInterrupted;
	public FMontageWaitSimpleDelegate OnCancelled;
	public void OnMontageBlendingOut(UObject Montage,bool bInterrupted) {}
	public void OnMontageInterrupted() {}
	public void OnMontageEnded(UObject Montage,bool bInterrupted) {}
	public UObject CreatePlayMontageAndWaitProxy(UObject OwningAbility,string TaskInstanceName,UObject MontageToPlay,float Rate/*=1.0f*/,string StartSection/*=NAME_None*/,bool bStopWhenAbilityEnds/*=true*/,float AnimRootMotionTranslationScale/*=1.0f*/,float StartTimeSeconds/*=0.0f*/) { return default; }
	public UAnimMontage MontageToPlay;
	public float Rate;
	public string StartSection;
	public float AnimRootMotionTranslationScale;
	public float StartTimeSeconds;
	public bool bStopWhenAbilityEnds;
}
