#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyPathHelpers.h")]
///<summary>Base class for cached property path segments</summary>
public partial struct FPropertyPathSegment {
// PropertyPathSegment
	public string Name;
	public int ArrayIndex;
	public UStruct Struct;
}
