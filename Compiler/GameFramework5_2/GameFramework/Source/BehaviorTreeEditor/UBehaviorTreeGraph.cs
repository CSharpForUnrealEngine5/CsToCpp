namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTreeGraph.h")]
public partial class UBehaviorTreeGraph : UAIGraph {
	public static UClass StaticClass() {return default;}
	///<summary>increased with every graph rebuild, used to refresh data from subtrees</summary>
	public int ModCounter;
	///<summary>bIsUsingModCounter</summary>
	public bool bIsUsingModCounter;
}
