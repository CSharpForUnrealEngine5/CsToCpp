namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/BTTask_FindAndUseGameplayBehaviorSmartObject.h")]
public partial class UBTTask_FindAndUseGameplayBehaviorSmartObject : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>Additional tag query to filter available smart objects. We&#39;ll query for smart</summary>
	public FGameplayTagQuery ActivityRequirements;
	///<summary>EQSRequest</summary>
	public FEQSParametrizedQueryExecutionRequest EQSRequest;
	///<summary>Used for smart object querying if EQSRequest is not configured</summary>
	public float Radius;
}
