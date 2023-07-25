#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGeometryOperations.h")]
///<summary>Experimental - Remesh input meshes</summary>
public partial class UDataprepRemeshOperation : UDataprepEditingOperation {
// DataprepRemeshOperation
	public int TargetTriangleCount;
	public float SmoothingStrength;
	public bool bDiscardAttributes;
	public ERemeshType RemeshType;
	public int RemeshIterations;
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
}
