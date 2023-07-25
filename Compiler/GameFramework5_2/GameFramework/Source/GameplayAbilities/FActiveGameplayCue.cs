#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
public partial struct FActiveGameplayCue {
// ActiveGameplayCue
	public FGameplayTag GameplayCueTag;
	public FPredictionKey PredictionKey;
	public FGameplayCueParameters Parameters;
	public bool bPredictivelyRemoved;
}
