#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionUpdateInfo {
	public int TargetId;
	public TWeakObjectPtr<AActor> Target;
	public FAIStimulus Stimulus;
}
