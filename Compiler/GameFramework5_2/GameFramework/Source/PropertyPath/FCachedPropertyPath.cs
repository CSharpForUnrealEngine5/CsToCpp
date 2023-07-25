#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyPathHelpers.h")]
///<summary>Base class for cached property paths</summary>
public partial struct FCachedPropertyPath {
// CachedPropertyPath
	public TArray<FPropertyPathSegment> Segments;
	public UFunction CachedFunction;
}
