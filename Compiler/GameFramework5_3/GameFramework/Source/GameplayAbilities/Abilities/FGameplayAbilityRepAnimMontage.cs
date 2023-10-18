namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about montages that is replicated to simulated clients</summary>
[CppInclude("Abilities/GameplayAbilityRepAnimMontage.h")]
public partial struct FGameplayAbilityRepAnimMontage {
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
