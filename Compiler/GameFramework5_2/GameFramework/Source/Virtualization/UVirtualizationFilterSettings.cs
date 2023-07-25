#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualizationFilterSettings.h")]
///<summary>Settings to use when determining if a package should be included/excluded from the</summary>
public partial class UVirtualizationFilterSettings : UObject {
// VirtualizationFilterSettings
	public TArray<string> ExcludePackagePaths;
	public TArray<string> IncludePackagePaths;
}
