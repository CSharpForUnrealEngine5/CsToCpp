#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BehaviorTreeTypes.h")]
///<summary>keep in sync with DescribeNodeResult()</summary>
[CppEnumInNamespace]
public enum EBTNodeResult {
	Succeeded=0,
	Failed=1,
	Aborted=2,
	InProgress=3,
}
