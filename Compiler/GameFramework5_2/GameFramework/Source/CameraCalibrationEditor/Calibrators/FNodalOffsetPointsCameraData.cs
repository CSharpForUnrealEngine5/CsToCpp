#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Calibrators/CameraNodalOffsetAlgoPoints.h")]
///<summary>Holds information of the camera pose for a given sample of a 2d-3d correlation</summary>
public partial struct FNodalOffsetPointsCameraData {
// NodalOffsetPointsCameraData
	public bool bIsValid;
	public uint UniqueId;
	public FTransform Pose;
	public bool bWasNodalOffsetApplied;
	public bool bWasDistortionEvaluated;
	public float InputFocus;
	public float InputZoom;
	public FTransform ParentPose;
	public uint ParentUniqueId;
	public FTransform CalibratorPose;
	public FTransform CalibratorParentPose;
	public TMap<uint,FTransform> CalibratorComponentPoses;
	public uint CalibratorUniqueId;
	public uint CalibratorParentUniqueId;
}
