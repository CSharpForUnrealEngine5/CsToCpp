namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used internally.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyCopy {
	public FStateTreePropertyIndirection SourceIndirection;
	public FStateTreePropertyIndirection TargetIndirection;
	public int CopySize;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType Type;
}
