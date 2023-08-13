namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_PathfindingBatch.h")]
public partial class UEnvQueryTest_PathfindingBatch : UEnvQueryTest_Pathfinding {
	public static UClass StaticClass() {return default;}
	///<summary>multiplier for max distance between point and context</summary>
	public FAIDataProviderFloatValue ScanRangeMultiplier;
}
