#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to start dragging one or more actors.</summary>
public partial struct FRCWebSocketNDisplayPreviewActorDragBeginBody {
// RCWebSocketNDisplayPreviewActorDragBeginBody
	public int RendererId;
	public TArray<string> Actors;
	public string PrimaryActor;
	public long SequenceNumber;
}
