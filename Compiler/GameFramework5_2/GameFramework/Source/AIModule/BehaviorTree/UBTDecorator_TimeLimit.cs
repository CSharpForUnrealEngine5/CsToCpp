#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Time Limit decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_TimeLimit.h")]
public partial class UBTDecorator_TimeLimit : UBTDecorator {
	///<summary>max allowed time for execution of underlying node</summary>
	public float TimeLimit;
}
