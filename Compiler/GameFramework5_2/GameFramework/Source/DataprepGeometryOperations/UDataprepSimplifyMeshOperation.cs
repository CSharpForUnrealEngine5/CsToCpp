#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepGeometryOperations.h")]
///<summary>Experimental - Simplify input meshes</summary>
public partial class UDataprepSimplifyMeshOperation : UDataprepEditingOperation {
// DataprepSimplifyMeshOperation
	public int TargetPercentage;
	public bool bDiscardAttributes;
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
}
