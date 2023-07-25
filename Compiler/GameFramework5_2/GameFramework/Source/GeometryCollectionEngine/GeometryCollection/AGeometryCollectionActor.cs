#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryCollection/GeometryCollectionActor.h")]
public partial class AGeometryCollectionActor : AActor {
// GeometryCollectionActor
	public UGeometryCollectionComponent GeometryCollectionComponent;
	public UGeometryCollectionDebugDrawComponent GeometryCollectionDebugDrawComponent_DEPRECATED;
	public bool RaycastSingle(FVector Start,FVector End,FHitResult OutHit) { return default; }
}
