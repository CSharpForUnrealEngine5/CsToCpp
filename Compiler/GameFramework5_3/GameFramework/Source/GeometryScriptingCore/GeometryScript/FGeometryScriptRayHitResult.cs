namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshSpatialFunctions.h")]
public partial struct FGeometryScriptRayHitResult {
	public bool bHit;
	public float RayParameter;
	public int HitTriangleID;
	public FVector HitPosition;
	public FVector HitBaryCoords;
}
