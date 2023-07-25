#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionBlueprintInfo {
// ActorPerceptionBlueprintInfo
	public AActor Target;
	public TArray<FAIStimulus> LastSensedStimuli;
	public bool bIsHostile;
}
