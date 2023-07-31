#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the result from an Interchange operation.</summary>
[CppInclude("InterchangeResult.h")]
public partial class UInterchangeResult : UObject {
	///<summary>SourceAssetName</summary>
	public string SourceAssetName;
	///<summary>DestinationAssetName</summary>
	public string DestinationAssetName;
	///<summary>AssetType</summary>
	public UClass AssetType;
	///<summary>InterchangeKey</summary>
	public string InterchangeKey;
}
