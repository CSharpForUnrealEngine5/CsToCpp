namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationSharingTypes.h")]
public partial struct FAnimationStateEntry {
	public byte State;
	public TArray<FAnimationSetup> AnimationSetups;
	public bool bOnDemand;
	public bool bAdditive;
	public float BlendTime;
	public bool bReturnToPreviousState;
	public bool bSetNextState;
	public byte NextState;
	public FPerPlatformInt MaximumNumberOfConcurrentInstances;
	public float WiggleTimePercentage;
	public bool bRequiresCurves;
}
