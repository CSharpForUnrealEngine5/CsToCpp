#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements UTT GameplayDebuggingComponent/ServerReplicateData crash</summary>
[CppInclude("UnitTests/Obsolete/UTT61_DebugReplicateData.h")]
public partial class UUTT61_DebugReplicateData : UClientUnitTest {
	///<summary>Reference to the GameplayDebuggingReplicator class</summary>
	public UClass RepClass;
	///<summary>Once the GameplayDebuggingReplicator is received, cache it</summary>
	public TWeakObjectPtr<AActor> Replicator;
}
