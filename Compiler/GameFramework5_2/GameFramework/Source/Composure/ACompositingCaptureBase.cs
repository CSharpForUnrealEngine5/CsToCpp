#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CompositingCaptureBase.h")]
///<summary>Base class for CG Compositing Elements</summary>
public partial class ACompositingCaptureBase : ACompositingElement {
// CompositingCaptureBase
	public USceneCaptureComponent2D SceneCaptureComponent2D;
	public bool bApplyDistortion;
	public FComponentReference LensComponentPicker;
	public float OverscanFactor;
	public float OriginalFocalLength;
	public UMaterialInstanceDynamic LastDistortionMID;
	public FDistortionHandlerPicker DistortionSource_DEPRECATED;
	public void UpdateDistortion() {}
}
