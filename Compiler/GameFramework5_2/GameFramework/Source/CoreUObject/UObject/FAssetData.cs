#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A struct to hold important information about an assets found by the Asset Registry</summary>
public partial struct FAssetData {
// AssetData
	public string ObjectPath;
	public string PackageName;
	public string PackagePath;
	public string AssetName;
	public string AssetClass;
	public FTopLevelAssetPath AssetClassPath;
}
