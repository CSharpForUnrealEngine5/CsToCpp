#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_PathingGrid.h")]
///<summary>Navigation grid, generates points on navmesh</summary>
public partial class UEnvQueryGenerator_PathingGrid : UEnvQueryGenerator_SimpleGrid {
// EnvQueryGenerator_PathingGrid
	public FAIDataProviderBoolValue PathToItem;
	public UClass NavigationFilter;
	public FAIDataProviderFloatValue ScanRangeMultiplier;
}
