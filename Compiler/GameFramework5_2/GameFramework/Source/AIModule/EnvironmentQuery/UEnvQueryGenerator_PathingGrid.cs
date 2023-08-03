#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Navigation grid, generates points on navmesh</summary>
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_PathingGrid.h")]
public partial class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid {
	public static UClass StaticClass() {return default;}
	///<summary>pathfinding direction</summary>
	public FAIDataProviderBoolValue PathToItem;
	///<summary>navigation filter to use in pathfinding</summary>
	public UClass NavigationFilter;
	///<summary>multiplier for max distance between point and context</summary>
	public FAIDataProviderFloatValue ScanRangeMultiplier;
}
