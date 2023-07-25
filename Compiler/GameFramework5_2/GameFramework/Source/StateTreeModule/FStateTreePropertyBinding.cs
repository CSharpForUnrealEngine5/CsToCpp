#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Describes property binding, the property from source path is copied into the property at the target path.</summary>
public partial struct FStateTreePropertyBinding {
// StateTreePropertyBinding
	public FStateTreePropertySegment SourcePath;
	public FStateTreePropertySegment TargetPath;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType CopyType;
}
