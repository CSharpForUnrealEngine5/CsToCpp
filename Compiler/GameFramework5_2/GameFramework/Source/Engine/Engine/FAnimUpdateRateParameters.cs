#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Container for Animation Update Rate parameters.</summary>
public partial struct FAnimUpdateRateParameters {
// AnimUpdateRateParameters
	public EUpdateRateShiftBucket ShiftBucket;
	public bool bInterpolateSkippedFrames;
	public bool bShouldUseLodMap;
	public bool bShouldUseMinLod;
	public bool bSkipUpdate;
	public bool bSkipEvaluation;
	public int UpdateRate;
	public int EvaluationRate;
	public float TickedPoseOffestTime;
	public float AdditionalTime;
	public int BaseNonRenderedUpdateRate;
	public int MaxEvalRateForInterpolation;
	public TArray<float> BaseVisibleDistanceFactorThesholds;
	public TMap<int,int> LODToFrameSkipMap;
	public int SkippedUpdateFrames;
	public int SkippedEvalFrames;
}
