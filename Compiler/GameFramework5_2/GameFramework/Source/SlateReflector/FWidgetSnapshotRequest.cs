#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a message that is used to request a widget snapshot from a remote target.</summary>
[CppInclude("WidgetSnapshotMessages.h")]
public partial struct FWidgetSnapshotRequest {
	public FGuid TargetInstanceId;
	public FGuid SnapshotRequestId;
}
