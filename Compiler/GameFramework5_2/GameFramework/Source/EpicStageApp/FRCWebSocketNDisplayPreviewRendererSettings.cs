#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Preview renderer settings exposed to WebSocket clients.</summary>
public partial struct FRCWebSocketNDisplayPreviewRendererSettings {
// RCWebSocketNDisplayPreviewRendererSettings
	public ERCWebSocketNDisplayPreviewRenderType RenderType;
	public ERCWebSocketNDisplayPreviewRenderProjectionType ProjectionType;
	public FIntPoint Resolution;
	public float FOV;
	public FRotator Rotation;
	public int JpegQuality;
	public bool IncludeActorPositions;
}
