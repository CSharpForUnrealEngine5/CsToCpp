#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGCollisionShapeData.h")]
public partial class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache {
	///<summary>Transform</summary>
	public FTransform Transform;
	///<summary>CachedBounds</summary>
	public FBox CachedBounds;
	///<summary>CachedStrictBounds</summary>
	public FBox CachedStrictBounds;
}
