#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Describes a batch of property copies from many sources to one target struct.</summary>
public partial struct FStateTreePropCopyBatch {
// StateTreePropCopyBatch
	public FStateTreeBindableStructDesc TargetStruct;
	public ushort BindingsBegin;
	public ushort BindingsEnd;
}
