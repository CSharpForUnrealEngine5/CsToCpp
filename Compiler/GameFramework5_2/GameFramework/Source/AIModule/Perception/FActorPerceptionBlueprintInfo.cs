#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionBlueprintInfo {
	public AActor Target;
	public TArray<FAIStimulus> LastSensedStimuli;
	public bool bIsHostile;
}
