namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the ImgMedia module.</summary>
[CppInclude("AndroidCameraSettings.h")]
public partial class UAndroidCameraSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether video samples should be cacheable (default = off).</summary>
	public bool CacheableVideoSampleBuffers;
}
