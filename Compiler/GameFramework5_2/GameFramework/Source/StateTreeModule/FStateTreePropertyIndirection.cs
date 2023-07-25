#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Property indirection is a resolved property path segment, used for accessing properties in structs.</summary>
public partial struct FStateTreePropertyIndirection {
// StateTreePropertyIndirection
	public FStateTreeIndex16 ArrayIndex;
	public ushort Offset;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
}
