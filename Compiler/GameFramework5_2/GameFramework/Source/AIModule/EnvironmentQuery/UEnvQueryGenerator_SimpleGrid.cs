namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple grid, generates points in 2D square around context</summary>
[CppInclude("EnvironmentQuery/Generators/EnvQueryGenerator_SimpleGrid.h")]
public partial class UEnvQueryGenerator_SimpleGrid : UEnvQueryGenerator_ProjectedPoints {
	public static UClass StaticClass() {return default;}
	///<summary>half of square&#39;s extent, like a radius</summary>
	public FAIDataProviderFloatValue GridSize;
	///<summary>generation density</summary>
	public FAIDataProviderFloatValue SpaceBetween;
	///<summary>context</summary>
	public UClass GenerateAround;
}
