namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Ability task to simply play a montage. Many games will want to make a modified version of this task that looks for game-specific events</summary>
[CppInclude("Abilities/Tasks/AbilityTask_PlayMontageAndWait.h")]
public partial class UAbilityTask_PlayMontageAndWait : UAbilityTask {
	public static UClass StaticClass() {return default;}
	///<summary>OnCompleted</summary>
	public FMontageWaitSimpleDelegate OnCompleted;
	///<summary>OnBlendOut</summary>
	public FMontageWaitSimpleDelegate OnBlendOut;
	///<summary>OnInterrupted</summary>
	public FMontageWaitSimpleDelegate OnInterrupted;
	///<summary>OnCancelled</summary>
	public FMontageWaitSimpleDelegate OnCancelled;
	///<summary>OnMontageBlendingOut</summary>
	public void OnMontageBlendingOut(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>OnMontageInterrupted</summary>
	public void OnMontageInterrupted() {}
	///<summary>OnMontageEnded</summary>
	public void OnMontageEnded(UAnimMontage Montage,bool bInterrupted) {}
	///<summary>Start playing an animation montage on the avatar actor and wait for it to finish</summary>
	public static UAbilityTask_PlayMontageAndWait CreatePlayMontageAndWaitProxy(UGameplayAbility OwningAbility,string TaskInstanceName,UAnimMontage MontageToPlay,float Rate/*=1.0f*/,string StartSection/*=NAME_None*/,bool bStopWhenAbilityEnds/*=true*/,float AnimRootMotionTranslationScale/*=1.0f*/,float StartTimeSeconds/*=0.0f*/) { return default; }
	///<summary>MontageToPlay</summary>
	public UAnimMontage MontageToPlay;
	///<summary>Rate</summary>
	public float Rate;
	///<summary>StartSection</summary>
	public string StartSection;
	///<summary>AnimRootMotionTranslationScale</summary>
	public float AnimRootMotionTranslationScale;
	///<summary>StartTimeSeconds</summary>
	public float StartTimeSeconds;
	///<summary>bStopWhenAbilityEnds</summary>
	public bool bStopWhenAbilityEnds;
}
