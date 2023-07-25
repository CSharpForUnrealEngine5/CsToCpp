#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
///<summary>Wrapper to hold config variables</summary>
public partial struct FEnvQueryManagerConfig {
// EnvQueryManagerConfig
	public float MaxAllowedTestingTime;
	public bool bTestQueriesUsingBreadth;
	public int QueryCountWarningThreshold;
	public double QueryCountWarningInterval;
	public double ExecutionTimeWarningSeconds;
	public double HandlingResultTimeWarningSeconds;
	public double GenerationTimeWarningSeconds;
}
