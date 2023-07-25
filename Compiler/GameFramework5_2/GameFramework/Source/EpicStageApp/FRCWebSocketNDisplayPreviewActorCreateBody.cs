#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to create an actor, optionally positioned relative to the previewed area.</summary>
public partial struct FRCWebSocketNDisplayPreviewActorCreateBody {
// RCWebSocketNDisplayPreviewActorCreateBody
	public int RendererId;
	public string ActorName;
	public string ActorClass;
	public string TemplatePath;
	public bool OverridePosition;
	public FVector2D Position;
	public bool OverrideColor;
	public FLinearColor Color;
	public bool bIsLightCardFlag;
	public int RequestId;
}
