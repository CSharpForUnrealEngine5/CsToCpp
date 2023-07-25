#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to stop dragging actors for a preview renderer.</summary>
public partial struct FRCWebSocketNDisplayPreviewActorDragEndBody {
// RCWebSocketNDisplayPreviewActorDragEndBody
	public int RendererId;
	public FVector2D DragPosition;
	public long SequenceNumber;
}
