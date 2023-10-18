namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionBlueprintInfo {
	public AActor Target;
	public TArray<FAIStimulus> LastSensedStimuli;
	public bool bIsHostile;
}
