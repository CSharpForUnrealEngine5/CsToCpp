namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for Animation Update Rate parameters.</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FAnimUpdateRateParameters {
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
