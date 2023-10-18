namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used internally.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyIndirection {
	public FStateTreeIndex16 ArrayIndex;
	public ushort Offset;
	public FStateTreeIndex16 NextIndex;
	public EStateTreePropertyAccessType Type;
	public UStruct InstanceStruct;
}
