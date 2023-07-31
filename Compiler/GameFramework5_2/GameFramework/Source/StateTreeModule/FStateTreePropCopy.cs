#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes property copy, the property from source is copied into the property at the target.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropCopy {
	public FStateTreePropertyIndirection SourceIndirection;
	public FStateTreePropertyIndirection TargetIndirection;
	public int CopySize;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType Type;
}
