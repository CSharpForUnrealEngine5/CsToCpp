#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper to hold config variables</summary>
[CppInclude("EnvironmentQuery/EnvQueryManager.h")]
public partial struct FEnvQueryManagerConfig {
	public float MaxAllowedTestingTime;
	public bool bTestQueriesUsingBreadth;
	public int QueryCountWarningThreshold;
	public double QueryCountWarningInterval;
	public double ExecutionTimeWarningSeconds;
	public double HandlingResultTimeWarningSeconds;
	public double GenerationTimeWarningSeconds;
}
