#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserMenuContexts.h")]
public partial class UContentBrowserFolderContext : UContentBrowserMenuContext {
	public static UClass StaticClass() {return default;}
	///<summary>bCanBeModified</summary>
	public bool bCanBeModified;
	///<summary>bNoFolderOnDisk</summary>
	public bool bNoFolderOnDisk;
	///<summary>NumAssetPaths</summary>
	public int NumAssetPaths;
	///<summary>NumClassPaths</summary>
	public int NumClassPaths;
	///<summary>SelectedPackagePaths</summary>
	public TArray<string> SelectedPackagePaths;
}
