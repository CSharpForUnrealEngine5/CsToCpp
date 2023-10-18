namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavFilters/NavigationQueryFilter.h")]
public partial struct FNavigationFilterArea {
	public UClass AreaClass;
	public float TravelCostOverride;
	public float EnteringCostOverride;
	public bool bIsExcluded;
	public bool bOverrideTravelCost;
	public bool bOverrideEnteringCost;
}
