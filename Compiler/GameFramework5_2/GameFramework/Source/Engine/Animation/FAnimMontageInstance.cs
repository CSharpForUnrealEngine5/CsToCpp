#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimMontage.h")]
public partial struct FAnimMontageInstance {
// AnimMontageInstance
	public UAnimMontage Montage;
	public bool bPlaying;
	public float DefaultBlendTimeMultiplier;
	public TArray<int> NextSections;
	public TArray<int> PrevSections;
	public TArray<FAnimNotifyEvent> ActiveStateBranchingPoints;
	public float Position;
	public float PlayRate;
	public FAlphaBlend Blend;
	public int DisableRootMotionCount;
}
