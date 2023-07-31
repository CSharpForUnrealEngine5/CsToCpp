#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A simple rig for simulating crane-like camera movements.</summary>
[CppInclude("CameraRig_Crane.h")]
public partial class ACameraRig_Crane : AActor {
	///<summary>Controls the pitch of the crane arm.</summary>
	public float CranePitch;
	///<summary>Controls the yaw of the crane arm.</summary>
	public float CraneYaw;
	///<summary>Controls the length of the crane arm.</summary>
	public float CraneArmLength;
	///<summary>Lock the mount pitch so that an attached camera is locked and pitched in the direction of the crane arm</summary>
	public bool bLockMountPitch;
	///<summary>Lock the mount yaw so that an attached camera is locked and oriented in the direction of the crane arm</summary>
	public bool bLockMountYaw;
	///<summary>Root component to give the whole actor a transform.</summary>
	public USceneComponent TransformComponent;
	///<summary>Component to control Yaw.</summary>
	public USceneComponent CraneYawControl;
	///<summary>Component to control Pitch.</summary>
	public USceneComponent CranePitchControl;
	///<summary>Component to define the attach point for cameras.</summary>
	public USceneComponent CraneCameraMount;
	///<summary>Preview meshes for visualization</summary>
	public UStaticMeshComponent PreviewMesh_CraneArm;
	///<summary>PreviewMesh_CraneBase</summary>
	public UStaticMeshComponent PreviewMesh_CraneBase;
	///<summary>PreviewMesh_CraneMount</summary>
	public UStaticMeshComponent PreviewMesh_CraneMount;
	///<summary>PreviewMesh_CraneCounterWeight</summary>
	public UStaticMeshComponent PreviewMesh_CraneCounterWeight;
}
