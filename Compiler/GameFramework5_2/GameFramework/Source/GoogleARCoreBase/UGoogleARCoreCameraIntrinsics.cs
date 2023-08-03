#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object wrapping the ArCameraIntrinsics data from the ARCore SDK.</summary>
[CppInclude("GoogleARCoreCameraIntrinsics.h")]
public partial class UGoogleARCoreCameraIntrinsics : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get the focal length in pixels.</summary>
	public  void GetFocalLength(float OutFX,float OutFY) {}
	///<summary>Get the principal point in pixels.</summary>
	public  void GetPrincipalPoint(float OutCX,float OutCY) {}
	///<summary>Get the image&#39;s width and height in pixels.</summary>
	public  void GetImageDimensions(int OutWidth,int OutHeight) {}
}
