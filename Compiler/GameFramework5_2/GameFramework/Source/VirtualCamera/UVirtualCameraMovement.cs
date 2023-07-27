#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualCameraMovement.h")]
///<summary>A class to handle the virtual Camera transform.</summary>
public partial class UVirtualCameraMovement : UObject {
// VirtualCameraMovement
	public  FTransform GetLocalTransform() { return default; }
	public  void SetLocalTransform(FTransform Transform) {}
	public  FTransform GetTransform() { return default; }
	public  void SetLocalAxis(FTransform InTransform) {}
	public  void ResetLocalAxis() {}
	public  void SetLocationScale(FVector LocationScale) {}
	public  void SetRotationScale(FRotator RotationScale) {}
}
