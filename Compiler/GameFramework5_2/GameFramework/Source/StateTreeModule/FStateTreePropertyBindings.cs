#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Runtime storage and execution of property bindings.</summary>
public partial struct FStateTreePropertyBindings {
// StateTreePropertyBindings
	public TArray<FStateTreeBindableStructDesc> SourceStructs;
	public TArray<FStateTreePropCopyBatch> CopyBatches;
	public TArray<FStateTreePropertyBinding> PropertyBindings;
	public TArray<FStateTreePropertySegment> PropertySegments;
	public TArray<FStateTreePropCopy> PropertyCopies;
	public TArray<FStateTreePropertyIndirection> PropertyIndirections;
}
