#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawPolygonTool.h")]
public partial class UDrawPolygonToolStandardProperties : UInteractiveToolPropertySet {
// DrawPolygonToolStandardProperties
	public EDrawPolygonDrawMode PolygonDrawMode;
	public bool bAllowSelfIntersections;
	public float FeatureSizeRatio;
	public int RadialSlices;
	public float Distance;
	public bool bShowGridGizmo;
	public EDrawPolygonExtrudeMode ExtrudeMode;
	public float ExtrudeHeight;
}
