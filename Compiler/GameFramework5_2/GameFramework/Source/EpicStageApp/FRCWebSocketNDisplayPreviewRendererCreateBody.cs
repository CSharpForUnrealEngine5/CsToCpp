#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to create an nDisplay preview renderer.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewRendererCreateBody {
	public string RootActorPath;
	public FRCWebSocketNDisplayPreviewRendererSettings Settings;
}
