#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassReplicationProcessor.h")]
///<summary>Base processor that handles replication and only runs on the server. You should derive from this per entity type (that require different replication processing). It and its derived classes</summary>
public partial class UMassReplicationProcessor : UMassProcessor {
// MassReplicationProcessor
	public UMassReplicationSubsystem ReplicationSubsystem;
}
