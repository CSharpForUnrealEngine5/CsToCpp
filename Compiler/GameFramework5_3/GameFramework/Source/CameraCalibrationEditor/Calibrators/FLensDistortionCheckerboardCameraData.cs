namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds camera information that can be used to add the samples</summary>
[CppInclude("Calibrators/CameraLensDistortionAlgoCheckerboard.h")]
public partial struct FLensDistortionCheckerboardCameraData {
	public bool bIsValid;
	public float InputFocus;
	public float InputZoom;
	public FTransform Pose;
	public bool bWasNodalOffsetApplied;
}
