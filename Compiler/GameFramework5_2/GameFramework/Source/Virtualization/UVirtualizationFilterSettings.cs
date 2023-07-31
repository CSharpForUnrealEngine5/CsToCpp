#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings to use when determining if a package should be included/excluded from the</summary>
[CppInclude("VirtualizationFilterSettings.h")]
public partial class UVirtualizationFilterSettings : UObject {
	///<summary>A list of package paths that we should always prevent being virtualized .</summary>
	public TArray<string> ExcludePackagePaths;
	///<summary>A list of package paths that we should always attempt to virtualize.</summary>
	public TArray<string> IncludePackagePaths;
}
