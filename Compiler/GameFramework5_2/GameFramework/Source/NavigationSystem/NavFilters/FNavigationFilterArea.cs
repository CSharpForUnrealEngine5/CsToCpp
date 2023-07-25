#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavFilters/NavigationQueryFilter.h")]
public partial struct FNavigationFilterArea {
// NavigationFilterArea
	public UClass AreaClass;
	public float TravelCostOverride;
	public float EnteringCostOverride;
	public bool bIsExcluded;
	public bool bOverrideTravelCost;
	public bool bOverrideEnteringCost;
}
