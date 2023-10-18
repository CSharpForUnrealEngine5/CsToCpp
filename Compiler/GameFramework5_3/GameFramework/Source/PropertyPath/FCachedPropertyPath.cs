namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for cached property paths</summary>
[CppInclude("PropertyPathHelpers.h")]
public partial struct FCachedPropertyPath {
	public TArray<FPropertyPathSegment> Segments;
	public UFunction CachedFunction;
}
