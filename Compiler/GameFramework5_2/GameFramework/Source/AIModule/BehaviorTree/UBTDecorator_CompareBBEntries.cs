#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blackboard comparison decorator node.</summary>
[CppInclude("BehaviorTree/Decorators/BTDecorator_CompareBBEntries.h")]
public partial class UBTDecorator_CompareBBEntries : UBTDecorator {
	public static UClass StaticClass() {return default;}
	///<summary>operation type</summary>
	public EBlackBoardEntryComparison Operator;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKeyA;
	///<summary>blackboard key selector</summary>
	public FBlackboardKeySelector BlackboardKeyB;
}
