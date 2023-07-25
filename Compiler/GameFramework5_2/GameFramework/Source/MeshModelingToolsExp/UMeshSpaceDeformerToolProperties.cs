#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSpaceDeformerTool.h")]
public partial class UMeshSpaceDeformerToolProperties : UInteractiveToolPropertySet {
// MeshSpaceDeformerToolProperties
	public ENonlinearOperationType SelectedOperationType;
	public float UpperBoundsInterval;
	public float LowerBoundsInterval;
	public float BendDegrees;
	public float TwistDegrees;
	public EFlareProfileType FlareProfileType;
	public float FlarePercentY;
	public bool bLockXAndYFlaring;
	public float FlarePercentX;
	public bool bLockBottom;
	public bool bShowOriginalMesh;
	public bool bDrawVisualization;
	public bool bAlignToNormalOnCtrlClick;
}
