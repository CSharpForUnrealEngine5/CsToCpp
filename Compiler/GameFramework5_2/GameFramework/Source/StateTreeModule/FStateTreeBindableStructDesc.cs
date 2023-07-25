#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Descriptor for a struct or class that can be a binding source or target.</summary>
public partial struct FStateTreeBindableStructDesc {
// StateTreeBindableStructDesc
	public UStruct Struct;
	public string Name;
	public EStateTreeBindableStructSource DataSource;
	public FGuid ID;
}
