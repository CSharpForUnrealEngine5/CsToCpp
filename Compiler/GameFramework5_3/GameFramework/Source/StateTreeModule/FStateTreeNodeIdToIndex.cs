namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pair of node id and its associated node index created at compilation.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeNodeIdToIndex {
	public FGuid Id;
	public FStateTreeIndex16 Index;
}
