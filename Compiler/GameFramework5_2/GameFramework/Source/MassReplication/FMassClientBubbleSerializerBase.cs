#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Classes derived from this will contain the IClientBubbleHandlerInterface derived class as well as the actual Fast Array.</summary>
[CppInclude("MassClientBubbleSerializerBase.h")]
public partial struct FMassClientBubbleSerializerBase {
	public UWorld World;
	public UMassSpawnerSubsystem SpawnerSubsystem;
	public UMassReplicationSubsystem ReplicationSubsystem;
}
