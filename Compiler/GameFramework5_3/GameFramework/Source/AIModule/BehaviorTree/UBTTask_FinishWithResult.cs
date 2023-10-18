namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instantly finishes with given result</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_FinishWithResult.h")]
public partial class UBTTask_FinishWithResult : UBTTaskNode {
	public static UClass StaticClass() {return default;}
	///<summary>allows adding random time to wait time</summary>
	public EBTNodeResult Result;
}
