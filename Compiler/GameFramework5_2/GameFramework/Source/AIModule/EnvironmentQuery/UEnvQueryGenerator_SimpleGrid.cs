#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_SimpleGrid.h")]
///<summary>Simple grid, generates points in 2D square around context</summary>
public partial class UEnvQueryGenerator_SimpleGrid : UEnvQueryGenerator_ProjectedPoints {
// EnvQueryGenerator_SimpleGrid
	public FAIDataProviderFloatValue GridSize;
	public FAIDataProviderFloatValue SpaceBetween;
	public UClass GenerateAround;
}
