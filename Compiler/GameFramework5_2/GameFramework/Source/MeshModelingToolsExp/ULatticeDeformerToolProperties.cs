#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LatticeDeformerTool.h")]
public partial class ULatticeDeformerToolProperties : UInteractiveToolPropertySet {
// LatticeDeformerToolProperties
	public int XAxisResolution;
	public int YAxisResolution;
	public int ZAxisResolution;
	public float Padding;
	public ELatticeInterpolationType InterpolationType;
	public bool bDeformNormals;
	public bool bCanChangeResolution;
	public EToolContextCoordinateSystem GizmoCoordinateSystem;
	public bool bSetPivotMode;
	public bool bSoftDeformation;
	public  void Constrain() {}
	public  void ClearConstraints() {}
}
