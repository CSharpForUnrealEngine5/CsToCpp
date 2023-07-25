#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetSnapshotMessages.h")]
///<summary>Implements a message that is used to receive a widget snapshot from a remote target.</summary>
public partial struct FWidgetSnapshotResponse {
// WidgetSnapshotResponse
	public FGuid SnapshotRequestId;
	public TArray<byte> SnapshotData;
}
