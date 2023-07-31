#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is used to receive a widget snapshot from a remote target.</summary>
[CppInclude("WidgetSnapshotMessages.h")]
public partial struct FWidgetSnapshotResponse {
	public FGuid SnapshotRequestId;
	public TArray<byte> SnapshotData;
}
