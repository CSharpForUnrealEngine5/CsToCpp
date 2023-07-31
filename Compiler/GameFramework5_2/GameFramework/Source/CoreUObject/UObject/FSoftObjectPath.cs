#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A struct that contains a string reference to an object, either a top level asset or a subobject.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FSoftObjectPath {
	public FTopLevelAssetPath AssetPath;
	public string SubPathString;
}
