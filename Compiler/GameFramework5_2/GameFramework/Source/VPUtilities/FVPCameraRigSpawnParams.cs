namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters used to custom the CameraRig that&#39;s created.</summary>
[CppInclude("VPCameraBlueprintLibrary.h")]
public partial struct FVPCameraRigSpawnParams {
	public bool bUseWorldSpace;
	public bool bUseFirstPointAsSpawnLocation;
	public EVPCameraRigSpawnLinearApproximationMode LinearApproximationMode;
	public float LinearApproximationParam;
}
