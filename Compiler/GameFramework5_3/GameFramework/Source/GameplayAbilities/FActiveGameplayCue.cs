namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCueInterface.h")]
public partial struct FActiveGameplayCue {
	public FGameplayTag GameplayCueTag;
	public FPredictionKey PredictionKey;
	public FGameplayCueParameters Parameters;
	public bool bPredictivelyRemoved;
}
