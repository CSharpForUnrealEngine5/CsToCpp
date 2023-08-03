#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wait task node.</summary>
[CppInclude("BehaviorTree/Tasks/BTTask_WaitBlackboardTime.h")]
public partial class UBTTask_WaitBlackboardTime : UBTTask_Wait {
	public static UClass StaticClass() {return default;}
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKey;
}
