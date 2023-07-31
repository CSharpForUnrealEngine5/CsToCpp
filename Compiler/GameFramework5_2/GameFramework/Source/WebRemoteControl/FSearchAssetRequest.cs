#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to search for an asset.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FSearchAssetRequest {
	public string Query;
	public FRCAssetFilter Filter;
	public int Limit;
}
