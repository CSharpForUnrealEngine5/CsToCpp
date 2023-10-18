namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A helper for monitoring collisions between components.</summary>
[CppInclude("LearningAgentsHelpers.h")]
public partial class UCollisionMonitorHelper : ULearningAgentsHelper {
	public static UClass StaticClass() {return default;}
	///<summary>Adds a new collision monitor helper to the given manager component.</summary>
	public static UCollisionMonitorHelper AddCollisionMonitorHelper(ULearningAgentsManagerComponent InManagerComponent,FName Name/*=NAME_None*/) { return default; }
	///<summary>Sets the component to monitor for collisions. Generally this should be called on the</summary>
	public void SetComponent(int AgentId,UPrimitiveComponent Component,FName OtherComponentTag/*=NAME_None*/) {}
	///<summary>Gets if a collision has occurred for this agent.</summary>
	public bool GetCollisionOccurred(int AgentId) { return default; }
	///<summary>Gets if a collision has occurred for this agent and resets the state of if a collision has occurred back to false.</summary>
	public bool GetAndResetCollisionOccurred(int AgentId) { return default; }
	///<summary>Resets the state of if a collision has occurred back to false.</summary>
	public void ResetCollisionOccurred(int AgentId) {}
	///<summary>HandleOnHit</summary>
	public void HandleOnHit(UPrimitiveComponent HitComponent,AActor OtherActor,UPrimitiveComponent OtherComp,FVector NormalImpulse,FHitResult Hit) {}
}
