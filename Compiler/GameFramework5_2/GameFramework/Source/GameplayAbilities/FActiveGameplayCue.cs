#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
public partial struct FActiveGameplayCue {
	public FGameplayTag GameplayCueTag;
	public FPredictionKey PredictionKey;
	public FGameplayCueParameters Parameters;
	public bool bPredictivelyRemoved;
}
