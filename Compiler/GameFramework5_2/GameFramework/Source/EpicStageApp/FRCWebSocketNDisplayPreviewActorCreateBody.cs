namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to create an actor, optionally positioned relative to the previewed area.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewActorCreateBody {
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
