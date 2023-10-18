namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Perception/AIPerceptionComponent.h")]
public partial struct FActorPerceptionUpdateInfo {
	public int TargetId;
	public TWeakObjectPtr<AActor> Target;
	public FAIStimulus Stimulus;
}
