namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Subsystem that keeps track of the latest component hits and allow mass entities to retrieve and handle them</summary>
[CppInclude("MassComponentHitSubsystem.h")]
public partial class UMassComponentHitSubsystem : UTickableWorldSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>OnHitCallback</summary>
	public void OnHitCallback(UPrimitiveComponent HitComp,AActor OtherActor,UPrimitiveComponent OtherComp,FVector NormalImpulse,FHitResult Hit) {}
	///<summary>SignalSubsystem</summary>
	public UMassSignalSubsystem SignalSubsystem;
	///<summary>AgentSubsystem</summary>
	public UMassAgentSubsystem AgentSubsystem;
	///<summary>HitResults</summary>
	public TMap<FMassEntityHandle,FMassHitResult> HitResults;
	///<summary>ComponentToEntityMap</summary>
	public TMap<UActorComponent,FMassEntityHandle> ComponentToEntityMap;
	///<summary>EntityToComponentMap</summary>
	public TMap<FMassEntityHandle,UActorComponent> EntityToComponentMap;
}
