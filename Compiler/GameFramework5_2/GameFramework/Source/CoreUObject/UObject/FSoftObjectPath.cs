#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>A struct that contains a string reference to an object, either a top level asset or a subobject.</summary>
public partial struct FSoftObjectPath {
// SoftObjectPath
	public FTopLevelAssetPath AssetPath;
	public string SubPathString;
}
