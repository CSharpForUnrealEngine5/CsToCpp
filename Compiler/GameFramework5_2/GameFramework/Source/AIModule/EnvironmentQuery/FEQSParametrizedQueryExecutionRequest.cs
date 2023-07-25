#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEQSParametrizedQueryExecutionRequest {
// EQSParametrizedQueryExecutionRequest
	public UEnvQuery QueryTemplate;
	public TArray<FAIDynamicParam> QueryConfig;
	public FBlackboardKeySelector EQSQueryBlackboardKey;
	public byte RunMode;
	public bool bUseBBKeyForQueryTemplate;
}
