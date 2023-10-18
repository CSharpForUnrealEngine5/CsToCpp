namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pair of transition id and its associated compact transition index created at compilation.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeTransitionIdToIndex {
	public FGuid Id;
	public FStateTreeIndex16 Index;
}
