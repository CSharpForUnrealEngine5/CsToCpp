#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraph.h")]
public partial class UBehaviorTreeGraph : UAIGraph {
	///<summary>increased with every graph rebuild, used to refresh data from subtrees</summary>
	public int ModCounter;
	///<summary>bIsUsingModCounter</summary>
	public bool bIsUsingModCounter;
}
