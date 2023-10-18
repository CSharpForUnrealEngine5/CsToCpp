namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a batch of property copies from many sources to one target struct.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyCopyBatch {
	public FStateTreeBindableStructDesc TargetStruct;
	public ushort BindingsBegin;
	public ushort BindingsEnd;
}
