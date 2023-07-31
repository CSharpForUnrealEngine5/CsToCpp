#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes a batch of property copies from many sources to one target struct.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropCopyBatch {
	public FStateTreeBindableStructDesc TargetStruct;
	public ushort BindingsBegin;
	public ushort BindingsEnd;
}
