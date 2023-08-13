namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Editor representation of a property path in StateTree.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreeEditorPropertyPath {
	public FGuid StructID;
	public TArray<string> Path;
}
