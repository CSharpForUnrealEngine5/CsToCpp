#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_Loop.h")]
///<summary>Loop decorator node.</summary>
public partial class UBTDecorator_Loop : UBTDecorator {
// BTDecorator_Loop
	public int NumLoops;
	public bool bInfiniteLoop;
	public float InfiniteLoopTimeoutTime;
}
