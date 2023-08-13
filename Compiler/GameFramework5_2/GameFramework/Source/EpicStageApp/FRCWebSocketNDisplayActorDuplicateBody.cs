namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to duplicate one or more actors.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayActorDuplicateBody {
	public TArray<string> Actors;
	public int RequestId;
}
