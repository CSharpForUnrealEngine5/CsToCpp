namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to create an nDisplay preview renderer.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewRendererCreateBody {
	public string RootActorPath;
	public FRCWebSocketNDisplayPreviewRendererSettings Settings;
}
