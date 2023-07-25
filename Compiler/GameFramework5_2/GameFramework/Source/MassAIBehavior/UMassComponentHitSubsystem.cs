#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassComponentHitSubsystem.h")]
///<summary>Subsystem that keeps track of the latest component hits and allow mass entities to retrieve and handle them</summary>
public partial class UMassComponentHitSubsystem : UTickableWorldSubsystem {
// MassComponentHitSubsystem
	public void OnHitCallback(UObject HitComp,UObject OtherActor,UObject OtherComp,FVector NormalImpulse,FHitResult Hit) {}
	public UMassSignalSubsystem SignalSubsystem;
	public UMassAgentSubsystem AgentSubsystem;
	public TMap<FMassEntityHandle,FMassHitResult> HitResults;
	public TMap<UActorComponent,FMassEntityHandle> ComponentToEntityMap;
	public TMap<FMassEntityHandle,UActorComponent> EntityToComponentMap;
}
