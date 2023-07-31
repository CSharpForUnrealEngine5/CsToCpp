#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a segment of a property path (see FStateTreePropertyPath). Used for storage only.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertySegment {
	public string Name;
	public FStateTreeIndex16 ArrayIndex;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
}
