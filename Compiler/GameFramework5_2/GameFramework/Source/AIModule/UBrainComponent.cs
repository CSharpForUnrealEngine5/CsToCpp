#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BrainComponent.h")]
public partial class UBrainComponent : UActorComponent {
// BrainComponent
	public UBlackboardComponent BlackboardComp;
	public AAIController AIOwner;
	public void StartLogic() {}
	public void RestartLogic() {}
	public void StopLogic(string Reason) {}
	public bool IsRunning() { return default; }
	public bool IsPaused() { return default; }
}
