#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationBudgetAllocatorParameters.h")]
///<summary>Parameter block used to control the behavior of the budget allocator</summary>
public partial struct FAnimationBudgetAllocatorParameters {
// AnimationBudgetAllocatorParameters
	public float BudgetInMs;
	public float MinQuality;
	public int MaxTickRate;
	public float WorkUnitSmoothingSpeed;
	public float AlwaysTickFalloffAggression;
	public float InterpolationFalloffAggression;
	public int InterpolationMaxRate;
	public int MaxInterpolatedComponents;
	public float InterpolationTickMultiplier;
	public float InitialEstimatedWorkUnitTimeMs;
	public int MaxTickedOffsreenComponents;
	public int StateChangeThrottleInFrames;
	public float BudgetFactorBeforeReducedWork;
	public float BudgetFactorBeforeReducedWorkEpsilon;
	public float BudgetPressureSmoothingSpeed;
	public int ReducedWorkThrottleMinInFrames;
	public int ReducedWorkThrottleMaxInFrames;
	public float BudgetFactorBeforeAggressiveReducedWork;
	public int ReducedWorkThrottleMaxPerFrame;
	public float BudgetPressureBeforeEmergencyReducedWork;
	public float AutoCalculatedSignificanceMaxDistance;
}
