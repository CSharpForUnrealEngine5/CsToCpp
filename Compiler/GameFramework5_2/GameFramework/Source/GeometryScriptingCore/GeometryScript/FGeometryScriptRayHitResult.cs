#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial struct FGeometryScriptRayHitResult {
// GeometryScriptRayHitResult
	public bool bHit;
	public float RayParameter;
	public int HitTriangleID;
	public FVector HitPosition;
	public FVector HitBaryCoords;
}
