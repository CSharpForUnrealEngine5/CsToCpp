namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to change the root DisplayCluster actor of an nDisplay preview renderer.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewRendererSetRootBody {
	public int RendererId;
	public string RootActorPath;
}
