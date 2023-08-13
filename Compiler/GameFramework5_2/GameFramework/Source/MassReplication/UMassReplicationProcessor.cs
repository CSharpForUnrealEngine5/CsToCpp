namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base processor that handles replication and only runs on the server. You should derive from this per entity type (that require different replication processing). It and its derived classes</summary>
[CppInclude("MassReplicationProcessor.h")]
public partial class UMassReplicationProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>ReplicationSubsystem</summary>
	public UMassReplicationSubsystem ReplicationSubsystem;
}
