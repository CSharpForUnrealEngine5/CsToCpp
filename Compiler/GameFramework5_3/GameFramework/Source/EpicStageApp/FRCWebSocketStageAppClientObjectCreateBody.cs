namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to create an object whose lifetime will be bound to the lifetime</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketStageAppClientObjectCreateBody {
	public UClass ObjectClass;
	public int RequestId;
}
