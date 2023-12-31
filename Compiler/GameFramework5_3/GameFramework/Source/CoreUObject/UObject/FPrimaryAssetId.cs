namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This identifies an object as a &quot;primary&quot; asset that can be searched for by the AssetManager and used in various tools</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FPrimaryAssetId {
	public FPrimaryAssetType PrimaryAssetType;
	public FName PrimaryAssetName;
}
