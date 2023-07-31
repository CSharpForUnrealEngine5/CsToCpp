#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An object that represents an acquired CPU-accessible camera image.</summary>
[CppInclude("GoogleARCoreCameraImage.h")]
public partial class UGoogleARCoreCameraImage : UObject {
	///<summary>Explicitly release the ARCore resources owned by this object.</summary>
	public  void Release() {}
	///<summary>Get the width of the image in pixels.</summary>
	public  int GetWidth() { return default; }
	///<summary>Get the height of the image in pixels.</summary>
	public  int GetHeight() { return default; }
	///<summary>Get the number of data planes in the image.</summary>
	public  int GetPlaneCount() { return default; }
}
