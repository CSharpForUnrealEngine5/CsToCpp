#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundConcurrency.h")]
public enum EMaxConcurrentResolutionRule {
	PreventNew=0,
	StopOldest=1,
	StopFarthestThenPreventNew=2,
	StopFarthestThenOldest=3,
	StopLowestPriority=4,
	StopQuietest=5,
	StopLowestPriorityThenPreventNew=6,
	Count=7,
}
