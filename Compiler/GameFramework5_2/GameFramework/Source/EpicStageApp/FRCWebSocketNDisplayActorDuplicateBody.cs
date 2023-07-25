#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StageAppRequest.h")]
///<summary>Holds a request made via websocket to duplicate one or more actors.</summary>
public partial struct FRCWebSocketNDisplayActorDuplicateBody {
// RCWebSocketNDisplayActorDuplicateBody
	public TArray<string> Actors;
	public int RequestId;
}
