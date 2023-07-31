#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameter block used to control the behavior of the budget allocator</summary>
[CppInclude("AnimationBudgetAllocatorParameters.h")]
public partial struct FAnimationBudgetAllocatorParameters {
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
