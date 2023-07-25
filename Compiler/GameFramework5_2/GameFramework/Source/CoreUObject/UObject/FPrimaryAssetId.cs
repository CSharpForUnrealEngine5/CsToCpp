#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>This identifies an object as a "primary" asset that can be searched for by the AssetManager and used in various tools</summary>
public partial struct FPrimaryAssetId {
// PrimaryAssetId
	public FPrimaryAssetType PrimaryAssetType;
	public string PrimaryAssetName;
}
