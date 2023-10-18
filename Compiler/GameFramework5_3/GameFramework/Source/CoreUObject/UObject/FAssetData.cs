namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct to hold important information about an assets found by the Asset Registry</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FAssetData {
	public FName ObjectPath;
	public FName PackageName;
	public FName PackagePath;
	public FName AssetName;
	public FName AssetClass;
	public FTopLevelAssetPath AssetClassPath;
}
