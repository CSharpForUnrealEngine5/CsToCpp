#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/Tests/EnvQueryTest_Pathfinding.h")]
public partial class UEnvQueryTest_Pathfinding : UEnvQueryTest {
	///<summary>testing mode</summary>
	public EEnvTestPathfinding TestMode;
	///<summary>context: other end of pathfinding test</summary>
	public UClass Context;
	///<summary>pathfinding direction</summary>
	public FAIDataProviderBoolValue PathFromContext;
	///<summary>if set, items with failed path will be invalidated (PathCost, PathLength)</summary>
	public FAIDataProviderBoolValue SkipUnreachable;
	///<summary>navigation filter to use in pathfinding</summary>
	public UClass FilterClass;
}
