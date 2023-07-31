#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Instantly finishes with given result</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_FinishWithResult.h")]
public partial class UBTTask_FinishWithResult : UBTTaskNode {
	///<summary>allows adding random time to wait time</summary>
	public EBTNodeResult Result;
}
