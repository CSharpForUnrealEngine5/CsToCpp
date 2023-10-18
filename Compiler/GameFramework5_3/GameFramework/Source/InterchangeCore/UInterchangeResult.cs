namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for the result from an Interchange operation.</summary>
[CppInclude("InterchangeResult.h")]
public partial class UInterchangeResult : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SourceAssetName</summary>
	public string SourceAssetName;
	///<summary>DestinationAssetName</summary>
	public string DestinationAssetName;
	///<summary>AssetType</summary>
	public UClass AssetType;
	///<summary>InterchangeKey</summary>
	public string InterchangeKey;
}
