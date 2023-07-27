#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/Decorators/BTDecorator_CompareBBEntries.h")]
///<summary>Blackboard comparison decorator node.</summary>
public partial class UBTDecorator_CompareBBEntries : UBTDecorator {
// BTDecorator_CompareBBEntries
	public EBlackBoardEntryComparison Operator;
	public FBlackboardKeySelector BlackboardKeyA;
	public FBlackboardKeySelector BlackboardKeyB;
}
