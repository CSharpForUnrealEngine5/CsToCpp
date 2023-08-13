namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Services/BTService_RunEQS.h")]
public partial class UBTService_RunEQS : UBTService_BlackboardBase {
	public static UClass StaticClass() {return default;}
	///<summary>EQSRequest</summary>
	public FEQSParametrizedQueryExecutionRequest EQSRequest;
	///<summary>bUpdateBBOnFail</summary>
	public bool bUpdateBBOnFail;
}
