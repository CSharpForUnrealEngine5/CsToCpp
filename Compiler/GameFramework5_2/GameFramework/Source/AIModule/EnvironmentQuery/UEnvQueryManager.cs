#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
public partial class UEnvQueryManager : UAISubsystem {
	///<summary>RunEQSQuery</summary>
	public static UEnvQueryInstanceBlueprintWrapper RunEQSQuery(UObject WorldContextObject,UEnvQuery QueryTemplate,UObject Querier,EEnvQueryRunMode RunMode,UClass WrapperClass) { return default; }
	///<summary>cache of instances</summary>
	public TArray<FEnvQueryInstanceCache> InstanceCache;
	///<summary>local cache of context objects for managing BP based objects</summary>
	public TArray<UEnvQueryContext> LocalContexts;
	///<summary>GCShieldedWrappers</summary>
	public TArray<UEnvQueryInstanceBlueprintWrapper> GCShieldedWrappers;
	///<summary>how long are we allowed to test per update, in seconds.</summary>
	public float MaxAllowedTestingTime;
	///<summary>whether we update EQS queries based on:</summary>
	public bool bTestQueriesUsingBreadth;
	///<summary>if greater than zero, we will warn once when the number of queries is greater than or equal to this number, and log the queries out</summary>
	public int QueryCountWarningThreshold;
	///<summary>how often (in seconds) we will warn about the number of queries (allows us to catch multiple occurrences in a session)</summary>
	public double QueryCountWarningInterval;
	///<summary>Maximum EQS execution duration (in seconds) before a warning is reported.</summary>
	public double ExecutionTimeWarningSeconds;
	///<summary>Maximum EQS Query FinishDelegate duration (in seconds) before a warning is reported.</summary>
	public double HandlingResultTimeWarningSeconds;
	///<summary>Maximum EQS Generator duration (in seconds) before a warning is reported.</summary>
	public double GenerationTimeWarningSeconds;
}
