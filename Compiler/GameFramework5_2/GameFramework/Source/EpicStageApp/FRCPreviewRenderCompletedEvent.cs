#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppResponse.h")]
///<summary>Event sent to a client that created a renderer.</summary>
public partial struct FRCPreviewRenderCompletedEvent {
// RCPreviewRenderCompletedEvent
	public string Type;
	public int RendererId;
	public string ImageBase64;
	public FIntPoint Resolution;
	public TArray<FRCPreviewRenderCompletedEventActorPosition> ActorPositions;
	public long SequenceNumber;
	public bool IsRealTimeDisabled;
}
