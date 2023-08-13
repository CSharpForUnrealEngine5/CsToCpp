namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for CG Compositing Elements</summary>
[CppInclude("CompositingCaptureBase.h")]
public partial class ACompositingCaptureBase : ACompositingElement {
	public static UClass StaticClass() {return default;}
	///<summary>Component used to generate the scene capture for this CG Layer</summary>
	public USceneCaptureComponent2D SceneCaptureComponent2D;
	///<summary>Whether to apply distortion as a post-process effect on this CG Layer</summary>
	public bool bApplyDistortion;
	///<summary>A component reference (customized) that allows the user to specify a component that this controller should control</summary>
	public FComponentReference LensComponentPicker;
	///<summary>Value used to augment the FOV of the scene capture to produce a CG image with enough data to distort</summary>
	public float OverscanFactor;
	///<summary>Focal length of the target camera before any overscan has been applied</summary>
	public float OriginalFocalLength;
	///<summary>Cached distortion MID produced by the Lens Distortion Handler, used to clean up the post-process materials in the case that the the MID changes</summary>
	public UMaterialInstanceDynamic LastDistortionMID;
	///<summary>DistortionSource_DEPRECATED</summary>
	public FDistortionHandlerPicker DistortionSource_DEPRECATED;
	///<summary>Update the state of the Lens Distortion Data Handler, and updates or removes the Distortion MID from the SceneCaptureComponent&#39;s post process materials, depending on whether distortion should be applied</summary>
	public void UpdateDistortion() {}
}
