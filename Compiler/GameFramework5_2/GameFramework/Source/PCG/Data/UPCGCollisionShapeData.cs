#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/PCGCollisionShapeData.h")]
public partial class UPCGCollisionShapeData : UPCGSpatialDataWithPointCache {
// PCGCollisionShapeData
	public FTransform Transform;
	public FBox CachedBounds;
	public FBox CachedStrictBounds;
}
