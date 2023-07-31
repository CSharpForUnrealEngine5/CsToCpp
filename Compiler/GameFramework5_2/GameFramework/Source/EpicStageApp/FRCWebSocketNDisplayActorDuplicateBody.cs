#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request made via websocket to duplicate one or more actors.</summary>
[CppInclude("StageAppRequest.h")]
public partial struct FRCWebSocketNDisplayActorDuplicateBody {
	public TArray<string> Actors;
	public int RequestId;
}
