namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnvironmentQuery/EnvQueryTypes.h")]
public partial struct FEQSParametrizedQueryExecutionRequest {
	public UEnvQuery QueryTemplate;
	public TArray<FAIDynamicParam> QueryConfig;
	public FBlackboardKeySelector EQSQueryBlackboardKey;
	public EEnvQueryRunMode RunMode;
	public bool bUseBBKeyForQueryTemplate;
}
