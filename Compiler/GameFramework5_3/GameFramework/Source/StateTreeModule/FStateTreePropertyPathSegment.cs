namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct describing a path segment in FStateTreePropertyPath.</summary>
[CppInclude("StateTreePropertyBindings.h")]
public partial struct FStateTreePropertyPathSegment {
	public FName Name;
	public int ArrayIndex;
	public UStruct InstanceStruct;
}
