#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Experimental - Remesh input meshes</summary>
[CppInclude("DataprepGeometryOperations.h")]
public partial class UDataprepRemeshOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Target triangle count</summary>
	public int TargetTriangleCount;
	///<summary>Amount of Vertex Smoothing applied within Remeshing</summary>
	public float SmoothingStrength;
	///<summary>Discard UVs and existing normals, allowing the remesher to ignore any UV and normal seams. New per-vertex normals are computed.</summary>
	public bool bDiscardAttributes;
	///<summary>Remeshing type</summary>
	public ERemeshType RemeshType;
	///<summary>Number of Remeshing passes</summary>
	public int RemeshIterations;
	///<summary>Mesh Boundary Constraint Type</summary>
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	///<summary>Group Boundary Constraint Type</summary>
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	///<summary>Material Boundary Constraint Type</summary>
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
}
