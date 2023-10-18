namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Runtime storage and execution of property bindings.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyBindings {
	public TArray<FStateTreeBindableStructDesc> SourceStructs;
	public TArray<FStateTreePropertyCopyBatch> CopyBatches;
	public TArray<FStateTreePropertyPathBinding> PropertyPathBindings;
	public TArray<FStateTreePropertyBinding> PropertyBindings_DEPRECATED;
	public TArray<FStateTreePropertySegment> PropertySegments_DEPRECATED;
	public TArray<FStateTreePropertyCopy> PropertyCopies;
	public TArray<FStateTreePropertyIndirection> PropertyIndirections;
}
