namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to start dragging one or more actors.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewActorDragBeginBody {
	public int RendererId;
	public TArray<string> Actors;
	public string PrimaryActor;
	public long SequenceNumber;
}
