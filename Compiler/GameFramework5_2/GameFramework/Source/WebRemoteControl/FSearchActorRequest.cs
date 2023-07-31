#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to search for an actor.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FSearchActorRequest {
	public string Query;
	public string Class;
	public int Limit;
}
