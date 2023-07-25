#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/DemoNetDriver.h")]
///<summary>Simulated network driver for recording and playing back game sessions.</summary>
public partial class UDemoNetDriver : UNetDriver {
// DemoNetDriver
	public TMap<string,FRollbackNetStartupActorInfo> RollbackNetStartupActors;
	public float CheckpointSaveMaxMSPerFrame;
	public TArray<FMulticastRecordOptions> MulticastRecordOptions;
	public TArray<APlayerController> SpectatorControllers;
}
