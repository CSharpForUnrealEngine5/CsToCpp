#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassClientBubbleSerializerBase.h")]
///<summary>Classes derived from this will contain the IClientBubbleHandlerInterface derived class as well as the actual Fast Array.</summary>
public partial struct FMassClientBubbleSerializerBase {
// MassClientBubbleSerializerBase
	public UWorld World;
	public UMassSpawnerSubsystem SpawnerSubsystem;
	public UMassReplicationSubsystem ReplicationSubsystem;
}
