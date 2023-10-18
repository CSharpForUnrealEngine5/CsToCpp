namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Representation of a property binding in StateTree</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyPathBinding {
	public FStateTreePropertyPath SourcePropertyPath;
	public FStateTreePropertyPath TargetPropertyPath;
	public FStateTreeIndex16 CompiledSourceStructIndex;
	public FStateTreeEditorPropertyPath SourcePath_DEPRECATED;
	public FStateTreeEditorPropertyPath TargetPath_DEPRECATED;
}
