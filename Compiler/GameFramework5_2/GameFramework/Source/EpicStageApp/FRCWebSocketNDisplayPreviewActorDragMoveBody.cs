#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to move the actors that are currently being dragged for a preview renderer.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewActorDragMoveBody {
	public int RendererId;
	public FVector2D DragPosition;
	public long SequenceNumber;
}
