namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/RemeshProperties.h")]
public partial class UMeshConstraintProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>If true, sharp edges are preserved</summary>
	public bool bPreserveSharpEdges;
	///<summary>Mesh Boundary Constraint Type</summary>
	public EMeshBoundaryConstraint MeshBoundaryConstraint;
	///<summary>Group Boundary Constraint Type</summary>
	public EGroupBoundaryConstraint GroupBoundaryConstraint;
	///<summary>Material Boundary Constraint Type</summary>
	public EMaterialBoundaryConstraint MaterialBoundaryConstraint;
	///<summary>Prevent normal flips</summary>
	public bool bPreventNormalFlips;
	///<summary>Prevent introduction of tiny triangles or slivers</summary>
	public bool bPreventTinyTriangles;
}
