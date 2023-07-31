#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LatticeDeformerTool.h")]
public partial class ULatticeDeformerToolProperties : UInteractiveToolPropertySet {
	///<summary>Number of lattice vertices along the X axis</summary>
	public int XAxisResolution;
	///<summary>Number of lattice vertices along the Y axis</summary>
	public int YAxisResolution;
	///<summary>Number of lattice vertices along the Z axis</summary>
	public int ZAxisResolution;
	///<summary>Relative distance the lattice extends from the mesh</summary>
	public float Padding;
	///<summary>Whether to use linear or cubic interpolation to get new mesh vertex positions from the lattice</summary>
	public ELatticeInterpolationType InterpolationType;
	///<summary>Whether to use approximate new vertex normals using the deformer</summary>
	public bool bDeformNormals;
	///<summary>Not user visible - used to disallow changing the lattice resolution after deformation</summary>
	public bool bCanChangeResolution;
	///<summary>Whether the gizmo&#39;s axes remain aligned with world axes or rotate as the gizmo is transformed</summary>
	public EToolContextCoordinateSystem GizmoCoordinateSystem;
	///<summary>If Set Pivot Mode is active, the gizmo can be repositioned without moving the selected lattice points</summary>
	public bool bSetPivotMode;
	///<summary>Whether to use soft deformation of the lattice</summary>
	public bool bSoftDeformation;
	///<summary>Constrain selected lattice points</summary>
	public  void Constrain() {}
	///<summary>Clear all constrained lattice points</summary>
	public  void ClearConstraints() {}
}
