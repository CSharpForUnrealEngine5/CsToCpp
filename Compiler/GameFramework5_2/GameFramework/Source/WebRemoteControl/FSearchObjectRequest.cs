#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlRequest.h")]
///<summary>Holds a request to search for an asset.</summary>
public partial struct FSearchObjectRequest {
// SearchObjectRequest
	public string Query;
	public string Class;
	public string Outer;
	public int Limit;
}
