#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Experimental - Simplify input meshes</summary>
[CppInclude("DataprepGeometryOperations.h")]
public partial class UDataprepSimplifyMeshOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Target percentage of original triangle count</summary>
	public int TargetPercentage;
	///<summary>Discard UVs and existing normals, allowing the simplifier to ignore any UV and normal seams. New per-vertex normals are computed.</summary>
	public bool bDiscardAttributes;
	///<summary>Mesh Boundary Constraint Type</summary>
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	///<summary>Group Boundary Constraint Type</summary>
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	///<summary>Material Boundary Constraint Type</summary>
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
}
