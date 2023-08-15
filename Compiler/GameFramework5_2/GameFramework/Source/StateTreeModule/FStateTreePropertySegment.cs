namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a segment of a property path (see FStateTreePropertyPath). Used for storage only.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertySegment {
	public FName Name;
	public FStateTreeIndex16 ArrayIndex;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
}
