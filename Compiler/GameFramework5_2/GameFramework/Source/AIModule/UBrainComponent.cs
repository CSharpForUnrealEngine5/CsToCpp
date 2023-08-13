namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BrainComponent.h")]
public partial class UBrainComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard component</summary>
	public UBlackboardComponent BlackboardComp;
	///<summary>AIOwner</summary>
	public AAIController AIOwner;
	///<summary>Starts brain logic. If brain is already running, will not do anything.</summary>
	public virtual void StartLogic() {}
	///<summary>Restarts currently running or previously ran brain logic.</summary>
	public virtual void RestartLogic() {}
	///<summary>Stops currently running brain logic.</summary>
	public virtual void StopLogic(string Reason) {}
	///<summary>IsRunning</summary>
	public virtual bool IsRunning() { return default; }
	///<summary>IsPaused</summary>
	public virtual bool IsPaused() { return default; }
}
