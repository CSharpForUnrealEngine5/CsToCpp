#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AutoDestroySubsystem.h")]
///<summary>The Auto destroy subsystem manages actors who have bAutoDestroyWhenFinished</summary>
public partial class UAutoDestroySubsystem : UTickableWorldSubsystem {
// AutoDestroySubsystem
	public  void OnActorEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	public TArray<AActor> ActorsToPoll;
}
