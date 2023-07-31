#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct that can reference a top level asset such as &#39;/Path/To/Package.AssetName&#39;</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FTopLevelAssetPath {
	public string PackageName;
	public string AssetName;
}
