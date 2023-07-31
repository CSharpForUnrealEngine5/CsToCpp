#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Loop decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_Loop.h")]
public partial class UBTDecorator_Loop : UBTDecorator {
	///<summary>number of executions</summary>
	public int NumLoops;
	///<summary>infinite loop</summary>
	public bool bInfiniteLoop;
	///<summary>timeout (when looping infinitely, when we finish a loop we will check whether we have spent this time looping, if we have we will stop looping). A negative value means loop forever.</summary>
	public float InfiniteLoopTimeoutTime;
}
