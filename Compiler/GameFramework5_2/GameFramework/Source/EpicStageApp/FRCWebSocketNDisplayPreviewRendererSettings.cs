#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Preview renderer settings exposed to WebSocket clients.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewRendererSettings {
	public ERCWebSocketNDisplayPreviewRenderType RenderType;
	public ERCWebSocketNDisplayPreviewRenderProjectionType ProjectionType;
	public FIntPoint Resolution;
	public float FOV;
	public FRotator Rotation;
	public int JpegQuality;
	public bool IncludeActorPositions;
}
