namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Property indirection is a resolved property path segment, used for accessing properties in structs.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyIndirection {
	public FStateTreeIndex16 ArrayIndex;
	public ushort Offset;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
}
