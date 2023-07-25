#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to change the root DisplayCluster actor of an nDisplay preview renderer.</summary>
public partial struct FRCWebSocketNDisplayPreviewRendererSetRootBody {
// RCWebSocketNDisplayPreviewRendererSetRootBody
	public int RendererId;
	public string RootActorPath;
}
