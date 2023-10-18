namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Descriptor for a struct or class that can be a binding source or target.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreeBindableStructDesc {
	public UStruct Struct;
	public FName Name;
	public EStateTreeBindableStructSource DataSource;
	public FGuid ID;
}
