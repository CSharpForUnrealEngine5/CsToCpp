#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Auto destroy subsystem manages actors who have bAutoDestroyWhenFinished</summary>
[CppInclude("Engine/AutoDestroySubsystem.h")]
public partial class UAutoDestroySubsystem : UTickableWorldSubsystem {
	///<summary>Callback for a registered actor&#39;s End Play so we can remove it from our known actors</summary>
	public  void OnActorEndPlay(AActor Actor,EEndPlayReason EndPlayReason) {}
	///<summary>Actors to check if they should auto destroy or not</summary>
	public TArray<AActor> ActorsToPoll;
}
