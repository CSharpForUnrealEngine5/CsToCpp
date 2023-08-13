namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements UTT GameplayDebuggingComponent/ServerReplicateData crash</summary>
[CppInclude("UnitTests/Obsolete/UTT61_DebugReplicateData.h")]
public partial class UUTT61_DebugReplicateData : UClientUnitTest {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the GameplayDebuggingReplicator class</summary>
	public UClass RepClass;
	///<summary>Once the GameplayDebuggingReplicator is received, cache it</summary>
	public TWeakObjectPtr<AActor> Replicator;
}
