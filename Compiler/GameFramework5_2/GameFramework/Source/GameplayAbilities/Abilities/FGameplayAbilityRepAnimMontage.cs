#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Abilities/GameplayAbilityRepAnimMontage.h")]
///<summary>Data about montages that is replicated to simulated clients</summary>
public partial struct FGameplayAbilityRepAnimMontage {
// GameplayAbilityRepAnimMontage
	public UAnimMontage AnimMontage;
	public float PlayRate;
	public float Position;
	public float BlendTime;
	public byte NextSectionID;
	public byte PlayInstanceId;
	public bool bRepPosition;
	public bool IsStopped;
	public bool SkipPositionCorrection;
	public bool bSkipPlayRate;
	public FPredictionKey PredictionKey;
	public byte SectionIdToPlay;
}
