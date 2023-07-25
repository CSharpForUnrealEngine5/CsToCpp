#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetSnapshotMessages.h")]
///<summary>Implements a message that is used to request a widget snapshot from a remote target.</summary>
public partial struct FWidgetSnapshotRequest {
// WidgetSnapshotRequest
	public FGuid TargetInstanceId;
	public FGuid SnapshotRequestId;
}
