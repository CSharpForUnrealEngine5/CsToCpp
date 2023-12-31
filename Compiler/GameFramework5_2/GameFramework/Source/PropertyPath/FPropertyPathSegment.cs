namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for cached property path segments</summary>
[CppInclude("PropertyPathHelpers.h")]
public partial struct FPropertyPathSegment {
	public FName Name;
	public int ArrayIndex;
	public UStruct Struct;
}
