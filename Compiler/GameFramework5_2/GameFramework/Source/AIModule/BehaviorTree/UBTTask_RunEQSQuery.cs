#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Run Environment Query System Query task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_RunEQSQuery.h")]
public partial class UBTTask_RunEQSQuery : UBTTask_BlackboardBase {
	public static UClass StaticClass() {return default;}
	///<summary>QueryTemplate</summary>
	public UEnvQuery QueryTemplate;
	///<summary>QueryParams</summary>
	public TArray<FEnvNamedValue> QueryParams;
	///<summary>QueryConfig</summary>
	public TArray<FAIDynamicParam> QueryConfig;
	///<summary>RunMode</summary>
	public EEnvQueryRunMode RunMode;
	///<summary>EQSQueryBlackboardKey</summary>
	public FBlackboardKeySelector EQSQueryBlackboardKey;
	///<summary>bUseBBKey</summary>
	public bool bUseBBKey;
	///<summary>EQSRequest</summary>
	public FEQSParametrizedQueryExecutionRequest EQSRequest;
	///<summary>bUpdateBBOnFail</summary>
	public bool bUpdateBBOnFail;
}
