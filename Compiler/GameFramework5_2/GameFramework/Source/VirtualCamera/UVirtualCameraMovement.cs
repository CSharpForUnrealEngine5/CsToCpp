#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A class to handle the virtual Camera transform.</summary>
[CppInclude("VirtualCameraMovement.h")]
public partial class UVirtualCameraMovement : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the unmodified local transform.</summary>
	public  FTransform GetLocalTransform() { return default; }
	///<summary>Set the local transform that will be modified by the scaling factor.</summary>
	public  void SetLocalTransform(FTransform Transform) {}
	///<summary>Get the modified transform.</summary>
	public  FTransform GetTransform() { return default; }
	///<summary>Set the transform from where the scaling factor will be calculated from.</summary>
	public  void SetLocalAxis(FTransform InTransform) {}
	///<summary>Remove the axis transform, all scaling factor will be calculated from the origin.</summary>
	public  void ResetLocalAxis() {}
	///<summary>Scale the local location of the local transform from the local axis.</summary>
	public  void SetLocationScale(FVector LocationScale) {}
	///<summary>Scale the local rotation of the local transform from the local axis.</summary>
	public  void SetRotationScale(FRotator RotationScale) {}
}
