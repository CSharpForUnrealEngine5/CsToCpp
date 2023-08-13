namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds a request to search for an asset.</summary>
[CppInclude("RemoteControlRequest.h")]
public partial struct FSearchAssetRequest {
	public string Query;
	public FRCAssetFilter Filter;
	public int Limit;
}
