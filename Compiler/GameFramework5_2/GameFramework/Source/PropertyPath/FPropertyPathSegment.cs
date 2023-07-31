#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for cached property path segments</summary>
[CppInclude("PropertyPathHelpers.h")]
public partial struct FPropertyPathSegment {
	public string Name;
	public int ArrayIndex;
	public UStruct Struct;
}
