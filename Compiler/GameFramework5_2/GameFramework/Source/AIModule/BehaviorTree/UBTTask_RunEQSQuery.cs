#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Tasks/BTTask_RunEQSQuery.h")]
///<summary>Run Environment Query System Query task node.</summary>
public partial class UBTTask_RunEQSQuery : UBTTask_BlackboardBase {
// BTTask_RunEQSQuery
	public UEnvQuery QueryTemplate;
	public TArray<FEnvNamedValue> QueryParams;
	public TArray<FAIDynamicParam> QueryConfig;
	public EEnvQueryRunMode RunMode;
	public FBlackboardKeySelector EQSQueryBlackboardKey;
	public bool bUseBBKey;
	public FEQSParametrizedQueryExecutionRequest EQSRequest;
	public bool bUpdateBBOnFail;
}
