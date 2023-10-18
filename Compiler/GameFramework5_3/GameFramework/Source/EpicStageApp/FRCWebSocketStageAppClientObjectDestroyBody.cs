namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to destroy an object whose lifetime is bound to the lifetime</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketStageAppClientObjectDestroyBody {
	public string ObjectPath;
	public int RequestId;
}
