#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavFilters/NavigationQueryFilter.h")]
///<summary>Class containing definition of a navigation query filter</summary>
public partial class UNavigationQueryFilter : UObject {
// NavigationQueryFilter
	public TArray<FNavigationFilterArea> Areas;
	public FNavigationFilterFlags IncludeFlags;
	public FNavigationFilterFlags ExcludeFlags;
}
