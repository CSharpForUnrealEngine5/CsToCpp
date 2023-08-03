#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simulated network driver for recording and playing back game sessions.</summary>
[CppInclude("Engine/DemoNetDriver.h")]
public partial class UDemoNetDriver : UNetDriver {
	public static UClass StaticClass() {return default;}
	///<summary>Net startup actors that need to be rolled back during scrubbing by being destroyed and re-spawned</summary>
	public TMap<string,FRollbackNetStartupActorInfo> RollbackNetStartupActors;
	///<summary>Maximum time allowed each frame to spend on saving a checkpoint. If 0, it will save the checkpoint in a single frame, regardless of how long it takes.</summary>
	public float CheckpointSaveMaxMSPerFrame;
	///<summary>Config data for multicast RPCs we might want to skip recording.</summary>
	public TArray<FMulticastRecordOptions> MulticastRecordOptions;
	///<summary>An array of all the spectator controllers (the main one and all splitscreen ones) that currently exist</summary>
	public TArray<APlayerController> SpectatorControllers;
}
