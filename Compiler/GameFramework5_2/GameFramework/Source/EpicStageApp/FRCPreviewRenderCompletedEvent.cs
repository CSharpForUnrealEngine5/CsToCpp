#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client that created a renderer.</summary>
[CppInclude("StageAppResponse.h")]
public partial struct FRCPreviewRenderCompletedEvent {
	public string Type;
	public int RendererId;
	public string ImageBase64;
	public FIntPoint Resolution;
	public TArray<FRCPreviewRenderCompletedEventActorPosition> ActorPositions;
	public long SequenceNumber;
	public bool IsRealTimeDisabled;
}
