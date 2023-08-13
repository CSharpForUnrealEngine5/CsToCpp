namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime storage and execution of property bindings.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyBindings {
	public TArray<FStateTreeBindableStructDesc> SourceStructs;
	public TArray<FStateTreePropCopyBatch> CopyBatches;
	public TArray<FStateTreePropertyBinding> PropertyBindings;
	public TArray<FStateTreePropertySegment> PropertySegments;
	public TArray<FStateTreePropCopy> PropertyCopies;
	public TArray<FStateTreePropertyIndirection> PropertyIndirections;
}
