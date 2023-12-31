namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class containing definition of a navigation query filter</summary>
[CppInclude("NavFilters/NavigationQueryFilter.h")]
public partial class UNavigationQueryFilter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>list of overrides for navigation areas</summary>
	public TArray<FNavigationFilterArea> Areas;
	///<summary>required flags of navigation nodes</summary>
	public FNavigationFilterFlags IncludeFlags;
	///<summary>forbidden flags of navigation nodes</summary>
	public FNavigationFilterFlags ExcludeFlags;
}
