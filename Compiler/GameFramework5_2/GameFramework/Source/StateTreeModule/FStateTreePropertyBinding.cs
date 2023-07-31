#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes property binding, the property from source path is copied into the property at the target path.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyBinding {
	public FStateTreePropertySegment SourcePath;
	public FStateTreePropertySegment TargetPath;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType CopyType;
}
