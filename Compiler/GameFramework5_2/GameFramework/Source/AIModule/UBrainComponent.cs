#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BrainComponent.h")]
public partial class UBrainComponent : UActorComponent {
	///<summary>blackboard component</summary>
	public UBlackboardComponent BlackboardComp;
	///<summary>AIOwner</summary>
	public AAIController AIOwner;
	///<summary>Starts brain logic. If brain is already running, will not do anything.</summary>
	public  void StartLogic() {}
	///<summary>Restarts currently running or previously ran brain logic.</summary>
	public  void RestartLogic() {}
	///<summary>Stops currently running brain logic.</summary>
	public  void StopLogic(string Reason) {}
	///<summary>IsRunning</summary>
	public  bool IsRunning() { return default; }
	///<summary>IsPaused</summary>
	public  bool IsPaused() { return default; }
}
