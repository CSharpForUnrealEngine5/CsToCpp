namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to send the DataPackPackets as RPC`s instead of using the CustomDeltaNetSerializer.</summary>
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
public partial struct FGameplayDebuggerDataPackRPCParams {
	public string CategoryName;
	public int DataPackIdx;
	public FGameplayDebuggerDataPackHeader Header;
	public TArray<byte> Data;
}
