#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerCategoryReplicator.h")]
///<summary>Struct used to send the DataPackPackets as RPC`s instead of using the CustomDeltaNetSerializer.</summary>
public partial struct FGameplayDebuggerDataPackRPCParams {
// GameplayDebuggerDataPackRPCParams
	public string CategoryName;
	public int DataPackIdx;
	public FGameplayDebuggerDataPackHeader Header;
	public TArray<byte> Data;
}
