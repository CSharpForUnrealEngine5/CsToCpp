#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPCameraBlueprintLibrary.h")]
///<summary>Parameters used to custom the CameraRig that's created.</summary>
public partial struct FVPCameraRigSpawnParams {
// VPCameraRigSpawnParams
	public bool bUseWorldSpace;
	public bool bUseFirstPointAsSpawnLocation;
	public EVPCameraRigSpawnLinearApproximationMode LinearApproximationMode;
	public float LinearApproximationParam;
}
