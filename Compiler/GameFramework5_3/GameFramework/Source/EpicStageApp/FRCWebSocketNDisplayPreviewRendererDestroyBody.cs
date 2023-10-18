namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to destroy an nDisplay preview renderer.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayPreviewRendererDestroyBody {
	public int RendererId;
}
