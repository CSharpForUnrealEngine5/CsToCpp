#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to create an nDisplay preview renderer.</summary>
public partial struct FRCWebSocketNDisplayPreviewRendererCreateBody {
// RCWebSocketNDisplayPreviewRendererCreateBody
	public string RootActorPath;
	public FRCWebSocketNDisplayPreviewRendererSettings Settings;
}
