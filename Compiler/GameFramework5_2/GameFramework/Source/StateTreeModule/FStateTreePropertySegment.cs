#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Describes a segment of a property path (see FStateTreePropertyPath). Used for storage only.</summary>
public partial struct FStateTreePropertySegment {
// StateTreePropertySegment
	public string Name;
	public FStateTreeIndex16 ArrayIndex;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
}
