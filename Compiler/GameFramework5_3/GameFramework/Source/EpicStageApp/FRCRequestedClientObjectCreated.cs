namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event sent to a client when a client-bound object was created at the request of the client.</summary>
[CppInclude("StageAppResponse.h")]
public partial struct FRCRequestedClientObjectCreated {
	public string Type;
	public string ObjectPath;
	public int RequestId;
}
