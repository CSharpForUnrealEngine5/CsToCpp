#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MirrorTool.h")]
public partial class UMirrorToolProperties : UInteractiveToolPropertySet {
// MirrorToolProperties
	public EMirrorOperationMode OperationMode;
	public bool bCropAlongMirrorPlaneFirst;
	public bool bWeldVerticesOnMirrorPlane;
	public double PlaneTolerance;
	public bool bAllowBowtieVertexCreation;
	public EMirrorCtrlClickBehavior CtrlClickBehavior;
	public bool bButtonsOnlyChangeOrientation;
	public bool bShowPreview;
	public EMirrorSaveMode SaveMode;
}
