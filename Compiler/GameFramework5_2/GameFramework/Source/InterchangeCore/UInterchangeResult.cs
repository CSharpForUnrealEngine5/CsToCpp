#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeResult.h")]
///<summary>Base class for the result from an Interchange operation.</summary>
public partial class UInterchangeResult : UObject {
// InterchangeResult
	public string SourceAssetName;
	public string DestinationAssetName;
	public UClass AssetType;
	public string InterchangeKey;
}
