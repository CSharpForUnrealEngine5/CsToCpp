#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
public partial class UEnvQueryManager : UAISubsystem {
// EnvQueryManager
	public UObject RunEQSQuery(UObject WorldContextObject,UObject QueryTemplate,UObject Querier,byte RunMode,UClass WrapperClass) { return default; }
	public TArray<FEnvQueryInstanceCache> InstanceCache;
	public TArray<UEnvQueryContext> LocalContexts;
	public TArray<UEnvQueryInstanceBlueprintWrapper> GCShieldedWrappers;
	public float MaxAllowedTestingTime;
	public bool bTestQueriesUsingBreadth;
	public int QueryCountWarningThreshold;
	public double QueryCountWarningInterval;
	public double ExecutionTimeWarningSeconds;
	public double HandlingResultTimeWarningSeconds;
	public double GenerationTimeWarningSeconds;
}
