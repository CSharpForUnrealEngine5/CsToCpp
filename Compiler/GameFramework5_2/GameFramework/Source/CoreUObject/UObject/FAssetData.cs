#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct to hold important information about an assets found by the Asset Registry</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAssetData {
	public string ObjectPath;
	public string PackageName;
	public string PackagePath;
	public string AssetName;
	public string AssetClass;
	public FTopLevelAssetPath AssetClassPath;
}
