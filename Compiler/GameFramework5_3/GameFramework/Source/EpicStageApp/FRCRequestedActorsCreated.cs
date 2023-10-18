namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client when light cards were created at the request of the client.</summary>
[CppInclude("StageAppResponse.h")]
public partial struct FRCRequestedActorsCreated {
	public string Type;
	public TArray<string> ActorPaths;
	public int RequestId;
}
