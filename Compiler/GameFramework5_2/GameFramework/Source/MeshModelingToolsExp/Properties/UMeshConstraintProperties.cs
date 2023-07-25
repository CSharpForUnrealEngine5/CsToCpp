#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RemeshProperties.h")]
public partial class UMeshConstraintProperties : UInteractiveToolPropertySet {
// MeshConstraintProperties
	public bool bPreserveSharpEdges;
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
	public bool bPreventNormalFlips;
	public bool bPreventTinyTriangles;
}
