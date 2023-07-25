#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionUpdateInfo {
// ActorPerceptionUpdateInfo
	public int TargetId;
	public TWeakObjectPtr<AActor> Target;
	public FAIStimulus Stimulus;
}
