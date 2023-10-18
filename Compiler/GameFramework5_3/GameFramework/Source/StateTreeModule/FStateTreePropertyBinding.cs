namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Deprecated. Describes property binding, the property from source path is copied into the property at the target path.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyBinding {
	public FStateTreePropertySegment SourcePath;
	public FStateTreePropertySegment TargetPath;
	public FStateTreeIndex16 SourceStructIndex;
	public EStateTreePropertyCopyType CopyType;
}
