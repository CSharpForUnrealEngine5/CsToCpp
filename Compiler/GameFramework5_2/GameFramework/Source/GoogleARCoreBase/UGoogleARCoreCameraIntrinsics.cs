#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GoogleARCoreCameraIntrinsics.h")]
///<summary>An object wrapping the ArCameraIntrinsics data from the ARCore SDK.</summary>
public partial class UGoogleARCoreCameraIntrinsics : UObject {
// GoogleARCoreCameraIntrinsics
	public  void GetFocalLength(float OutFX,float OutFY) {}
	public  void GetPrincipalPoint(float OutCX,float OutCY) {}
	public  void GetImageDimensions(int OutWidth,int OutHeight) {}
}
