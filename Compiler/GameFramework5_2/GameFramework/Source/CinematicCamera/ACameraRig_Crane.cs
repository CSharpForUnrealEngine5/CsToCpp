#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CameraRig_Crane.h")]
///<summary>A simple rig for simulating crane-like camera movements.</summary>
public partial class ACameraRig_Crane : AActor {
// CameraRig_Crane
	public float CranePitch;
	public float CraneYaw;
	public float CraneArmLength;
	public bool bLockMountPitch;
	public bool bLockMountYaw;
	public USceneComponent TransformComponent;
	public USceneComponent CraneYawControl;
	public USceneComponent CranePitchControl;
	public USceneComponent CraneCameraMount;
	public UStaticMeshComponent PreviewMesh_CraneArm;
	public UStaticMeshComponent PreviewMesh_CraneBase;
	public UStaticMeshComponent PreviewMesh_CraneMount;
	public UStaticMeshComponent PreviewMesh_CraneCounterWeight;
}
