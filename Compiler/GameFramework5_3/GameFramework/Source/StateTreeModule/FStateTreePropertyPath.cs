namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Representation of a property path used for property binding in StateTree.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyPath {
	public FGuid StructID;
	public TArray<FStateTreePropertyPathSegment> Segments;
}
