#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Describes property copy, the property from source is copied into the property at the target.</summary>
public partial struct FStateTreePropCopy {
// StateTreePropCopy
	public FStateTreePropertyIndirection SourceIndirection;
	public FStateTreePropertyIndirection TargetIndirection;
	public int CopySize;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType Type;
}
