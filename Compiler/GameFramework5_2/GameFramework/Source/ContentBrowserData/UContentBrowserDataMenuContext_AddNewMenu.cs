#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContentBrowserDataMenuContexts.h")]
public partial class UContentBrowserDataMenuContext_AddNewMenu : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SelectedPaths</summary>
	public TArray<string> SelectedPaths;
	///<summary>At least one of the selected paths maps to a mounted content root</summary>
	public bool bContainsValidPackagePath;
	///<summary>bCanBeModified</summary>
	public bool bCanBeModified;
	///<summary>OwnerDomain</summary>
	public EContentBrowserDataMenuContext_AddNewMenuDomain OwnerDomain;
}
