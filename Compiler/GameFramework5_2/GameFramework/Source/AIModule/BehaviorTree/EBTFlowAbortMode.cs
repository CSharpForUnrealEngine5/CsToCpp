#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeTypes.h")]
///<summary>keep in sync with DescribeFlowAbortMode()</summary>
[CppEnumInNamespace]
public enum EBTFlowAbortMode {
	None=0,
	LowerPriority=1,
	Self=2,
	Both=3,
}
