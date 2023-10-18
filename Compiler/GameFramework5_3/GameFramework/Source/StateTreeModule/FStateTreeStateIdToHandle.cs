namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pair of state guid and its associated state handle created at compilation.</summary>
[CppInclude("StateTreeTypes.h")]
public partial struct FStateTreeStateIdToHandle {
	public FGuid Id;
	public FStateTreeStateHandle Handle;
}
