#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
